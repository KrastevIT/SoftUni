/* 01 Employees with Salary Above 35000 */
USE SoftUni

CREATE PROC usp_GetEmployeesSalaryAbove35000
AS
SELECT e.FirstName, e.LastName
FROM Employees AS e
WHERE e.Salary > 35000

/* 02 Employees with Salary Above Number */
CREATE PROC usp_GetEmployeesSalaryAboveNumber(@Salary DECIMAL(18, 4))
AS
SELECT e.FirstName, e.LastName
FROM Employees AS e
WHERE e.Salary >= @Salary

EXEC usp_GetEmployeesSalaryAboveNumber 48100

/* 03 Town Names Starting With */
CREATE PROC  usp_GetTownsStartingWith(@StartWith NVARCHAR(50))
AS
SELECT t.[Name]
FROM Towns AS t
WHERE t.[Name] LIKE @StartWith + '%'

EXEC usp_GetTownsStartingWith 'b'

/* 04 Employees from Town */
CREATE PROC usp_GetEmployeesFromTown(@TownName NVARCHAR(50))
AS
SELECT e.FirstName, e.LastName
FROM Employees AS e
JOIN Addresses AS a ON a.AddressID = e.AddressID 
JOIN Towns AS t ON t.TownID = a.TownID
WHERE t.[Name] = @TownName

EXEC usp_GetEmployeesFromTown 'Sofia'

/* 05 Salary Level Function */
CREATE FUNCTION  ufn_GetSalaryLevel(@salary DECIMAL(18,4))
RETURNS VARCHAR(7)
AS
BEGIN
	DECLARE @salaryLevel VARCHAR(7)

	IF(@salary < 30000)
	BEGIN
		SET @salaryLevel = 'Low'
	END
	ELSE IF(@salary <= 50000)
	BEGIN
	SET @salaryLevel = 'Average'
	END
	ELSE
	BEGIN
	SET @salaryLevel = 'High'
	END
	
	RETURN @salaryLevel
END

SELECT e.Salary, dbo.ufn_GetSalaryLevel(e.Salary)
FROM Employees AS e

/* 06 Employees by Salary Level */
CREATE PROC usp_EmployeesBySalaryLevel(@salaryLevel VARCHAR(7))
AS
SELECT e.FirstName, e.LastName
FROM Employees AS e
WHERE dbo.ufn_GetSalaryLevel(e.Salary) = @salaryLevel

EXEC usp_EmployeesBySalaryLevel high

/* 07 Define Function */
CREATE FUNCTION ufn_IsWordComprised(@setOfLetters VARCHAR(MAX), @word VARCHAR(MAX))
RETURNS BIT
AS
BEGIN
	DECLARE @counter INT = 1
	DECLARE @currentLetter CHAR

	WHILE(@counter <= LEN(@word))
	BEGIN
		SET @currentLetter = SUBSTRING(@word, @counter, 1)

		DECLARE @charIndex INT = CHARINDEX(@currentLetter, @setOfLetters)

		IF(@charIndex <= 0)
		BEGIN
			RETURN 0
		END

		SET @counter += 1

	END

	RETURN 1
	
END

-- 08 Delete Employees and Departments --
CREATE PROC usp_DeleteEmployeesFromDepartment(@departmentId INT)
AS
DELETE FROM EmployeesProjects
WHERE EmployeeID IN (SELECT EmployeeID FROM Employees WHERE DepartmentID = @departmentId)

UPDATE Employees
SET ManagerID = NULL
WHERE ManagerID IN (SELECT EmployeeID FROM Employees WHERE DepartmentID = @departmentId)

ALTER TABLE Departments
ALTER COLUMN ManagerID INT

UPDATE Departments
SET ManagerID = NULL
WHERE DepartmentID = @departmentId

DELETE FROM Employees
WHERE DepartmentID = @departmentId

DELETE FROM Departments
WHERE DepartmentID = @departmentId

SELECT COUNT(*)
FROM Employees
WHERE DepartmentID = @departmentId

-- 09 Find Full Name
USE Bank

CREATE PROC usp_GetHoldersFullName
AS
SELECT a.FirstName + ' ' + a.LastName  AS [Full Name]
FROM AccountHolders AS a

-- 10 People with Balance Higher Than --
CREATE PROC usp_GetHoldersWithBalanceHigherThan @minBalance DECIMAL(18,2)
AS
SELECT ah.FirstName, ah.LastName
FROM AccountHolders AS ah
JOIN Accounts AS a ON a.AccountHolderId = ah.Id
GROUP BY ah.FirstName, ah.LastName
HAVING SUM(a.Balance) > @minBalance
ORDER BY ah.FirstName, ah.LastName

-- 11 Future Value Function --
GO

CREATE FUNCTION ufn_CalculateFutureValue(@sum DECIMAL(18,2), @Interest FLOAT, @years INT)
RETURNS DECIMAL(20,4)
AS
BEGIN
	RETURN @Sum * POWER(1 + @Interest, @Years)
END

-- 12 Calculating Interest--
USE Bank
GO

CREATE PROC usp_CalculateFutureValueForAccount(@AccountID INT, @InterestRate FLOAT) AS
SELECT 
	a.Id AS [Account Id], 
	ah.FirstName AS [First Name],
	ah.LastName AS [Last Name],
	a.Balance AS [Current Balance],
	dbo.ufn_CalculateFutureValue(a.Balance, @InterestRate, 5) AS [Balance in 5 years] 
	FROM Accounts AS a
JOIN AccountHolders AS ah
ON a.AccountHolderId = ah.Id AND a.Id = @AccountID

-- 13 *Cash in User Games Odd Rows */
USE Diablo

GO

CREATE FUNCTION ufn_CashInUsersGames(@gameName NVARCHAR(100))
RETURNS TABLE
AS
RETURN 
	SELECT SUM(r.Cash) AS [SumCash]
	  FROM (SELECT g.[Name],
	               us.Cash,
	  	       ROW_NUMBER() OVER (PARTITION BY @gameName ORDER BY us.Cash DESC)
	            AS [Row Number]
	          FROM Games AS g
	          JOIN UsersGames AS us
	            ON us.GameId = g.Id
	         WHERE g.[Name] = @gameName) AS r
	  WHERE r.[Row Number] % 2 != 0

-- 14 Create Table Logs --
USE Bank

CREATE TABLE Logs (
	LogId INT PRIMARY KEY IDENTITY,
	AccountId INT FOREIGN KEY REFERENCES Accounts(Id),
	OldSum DECIMAL(18,2),
	NewSum DECIMAL(18,2)
)
GO

CREATE TRIGGER tr_AccountChanges ON Accounts FOR UPDATE
AS
BEGIN
		DECLARE @accountId INT
		DECLARE @oldSum DECIMAL(15, 2)
		DECLARE @newSum DECIMAL(15, 2)

		SET @accountId = (SELECT i.Id FROM inserted as i)

		SET @oldSum = (SELECT d.Balance FROM deleted AS d)

		SET @newSum = (SELECT i.Balance FROM inserted AS i)

		INSERT INTO Logs(AccountId, OldSum, NewSum)
		VALUES		    (@accountId, @oldSum, @newSum)
END

-- 15 Create Table Emails --
CREATE TRIGGER tr_CreateEmail ON Logs FOR INSERT
AS
BEGIN
	DECLARE @recipient INT;
	DECLARE @subject VARCHAR(200);
	DECLARE @oldBalance DECIMAL(15, 2);
	DECLARE @newBalance DECIMAL(15, 2);
	DECLARE @body VARCHAR(200);

	SET @recipient = (SELECT i.AccountId FROM inserted AS i)
	SET @subject = 'Balance change for account: ' + CAST(@recipient AS VARCHAR(MAX))
	SET @oldBalance = (SELECT i.OldSum FROM inserted AS i)
	SET @newBalance = (SELECT i.NewSum FROM inserted AS i)
	SET @body = 'On ' + CAST(GETDATE() AS VARCHAR(MAX)) 
	            + ' your balance was changed from ' + CAST(@oldBalance AS VARCHAR(MAX))
		    + ' to ' + CAST(@newBalance AS VARCHAR(MAX))

	INSERT INTO NotificationEmails(Recipient, [Subject], Body)
	VALUES	    (@recipient, @subject, @body)
END

-- 16 Deposit Money --
CREATE PROC usp_DepositMoney(@accountId INT, @moneyAmount DECIMAL(15, 4))
AS
BEGIN TRANSACTION
	IF (@moneyAmount < 0 OR @moneyAmount IS NULL)
	BEGIN
		ROLLBACK
		RAISERROR('Invalid amount of money', 16, 1)
		RETURN
	END

	IF (NOT EXISTS(
		SELECT a.Id FROM Accounts AS a 
		WHERE a.Id = @AccountId) OR @accountId IS NULL)
	BEGIN 
		ROLLBACK
		RAISERROR('Invalid accountId', 16, 2)
		RETURN
	END

	UPDATE Accounts
	   SET Balance += @moneyAmount
	 WHERE Id = @accountId
COMMIT

-- 17 Withdraw Money Procedure --

CREATE PROC usp_WithdrawMoney (@accountId INT, @moneyAmount DECIMAL(15, 4))
AS
BEGIN TRANSACTION
	IF (@moneyAmount < 0 OR @moneyAmount IS NULL)
	BEGIN
		ROLLBACK
		RAISERROR('Invalid amount of money', 16, 1)
		RETURN
	END

	IF (NOT EXISTS(
		SELECT a.Id FROM Accounts AS a 
		WHERE a.Id = @AccountId) OR @accountId IS NULL)
	BEGIN 
		ROLLBACK
		RAISERROR('Invalid accountId', 16, 2)
		RETURN
	END

	UPDATE Accounts
	   SET Balance -= @moneyAmount
	 WHERE Id = @accountId
COMMIT

-- 18 Money Transfer --
CREATE PROC usp_TransferMoney(@senderId INT, @receiverId INT, @amount DECIMAL(15, 4))
AS
BEGIN TRANSACTION
	IF (@amount < 0 OR @amount IS NULL)
	BEGIN
		ROLLBACK
		RAISERROR('Invalid amount of money', 16, 1)
		RETURN
	END

	IF (NOT EXISTS(
		SELECT * FROM Accounts a
		WHERE a.Id = @senderId) OR @senderId IS NULL)
	BEGIN
		ROLLBACK
		RAISERROR('Invalid senderId', 16, 2)
		RETURN
	END

	IF (NOT EXISTS(
		SELECT * FROM Accounts a
		WHERE a.Id = @receiverId) OR @receiverId IS NULL)
	BEGIN
		ROLLBACK
		RAISERROR('Invalid receiverId', 16, 3)
		RETURN
	END

	EXEC dbo.usp_DepositMoney @receiverId, @amount
	EXEC dbo.usp_WithdrawMoney @senderId, @amount

COMMIT

-- 21 Employees with Three Projects --
CREATE PROC usp_AssignProject(@emloyeeId INT, @projectID INT) 
AS
BEGIN TRANSACTION
	DECLARE @projectsCount INT;

	SET @projectsCount = (SELECT COUNT(ep.EmployeeID)
				FROM EmployeesProjects AS ep
                               WHERE ep.EmployeeID = @emloyeeId)

	IF (@projectsCount >= 3)
	BEGIN
		ROLLBACK
		RAISERROR('The employee has too many projects!', 16, 1)
		RETURN
	END

	INSERT INTO EmployeesProjects(EmployeeID, ProjectID)
	VALUES	    (@emloyeeId, @projectID)
COMMIT

-- 22 Delete Employees --
CREATE TRIGGER tr_DeletedEmployees ON Employees FOR DELETE
AS
BEGIN
	INSERT INTO Deleted_Employees(FirstName, LastName, MiddleName, JobTitle, DepartmentId, Salary)
	     SELECT d.FirstName, d.LastName, d.MiddleName, d.JobTitle, d.DepartmentID, d.Salary 
	       FROM deleted AS d
END