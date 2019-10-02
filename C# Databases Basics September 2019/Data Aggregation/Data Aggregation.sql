/* 01 Records’ Count */
USE Gringotts

SELECT COUNT(*)
AS Count 
FROM WizzardDeposits

/* 02 Longest Magic Wand */
SELECT MAX(MagicWandSize)
AS LongestMagicWand
FROM WizzardDeposits

/* 03 Longest Magic Wand per Deposit Groups */
SELECT DepositGroup, MAX(MagicWandSize) AS LongestMagicWand
FROM WizzardDeposits
GROUP BY DepositGroup

/* 04 Smallest Deposit Group per Magic Wand Size */
SELECT TOP 2 DepositGroup
FROM WizzardDeposits
GROUP BY DepositGroup
ORDER BY AVG(MagicWandSize)

/* 05 Deposits Sum */
SELECT DepositGroup, SUM(DepositAmount) AS TotalSum
FROM WizzardDeposits
GROUP BY DepositGroup

/* 06 Deposits Sum for Ollivander Family */
SELECT DepositGroup, SUM(DepositAmount) AS TotamSum
FROM WizzardDeposits
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup 

/* 07 Deposits Filter */
SELECT DepositGroup, SUM(DepositAmount) AS TotamSum
FROM WizzardDeposits
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup 
HAVING SUM(DepositAmount) < 150000
ORDER BY [TotamSum] DESC

/* 08 Deposit Charge */
SELECT DepositGroup, MagicWandCreator, MIN(DepositCharge) AS MinDepositCharge
FROM WizzardDeposits
GROUP BY DepositGroup, MagicWandCreator
ORDER BY MagicWandCreator, DepositGroup

/* 09 Age Groups */

SELECT
CASE
	WHEN Age BETWEEN 0 AND 10 THEN '[0-10]'
	WHEN Age BETWEEN 0 AND 20 THEN '[11-20]'
	WHEN Age BETWEEN 0 AND 30 THEN '[21-30]'
	WHEN Age BETWEEN 0 AND 40 THEN '[31-40]'
	WHEN Age BETWEEN 0 AND 50 THEN '[41-50]'
	WHEN Age BETWEEN 0 AND 60 THEN '[51-60]'
	ELSE '[61+]'
END AS [AgeGroup],
COUNT(*) AS [WizardCount]
FROM WizzardDeposits 
GROUP BY CASE
	WHEN Age BETWEEN 0 AND 10 THEN '[0-10]'
	WHEN Age BETWEEN 0 AND 20 THEN '[11-20]'
	WHEN Age BETWEEN 0 AND 30 THEN '[21-30]'
	WHEN Age BETWEEN 0 AND 40 THEN '[31-40]'
	WHEN Age BETWEEN 0 AND 50 THEN '[41-50]'
	WHEN Age BETWEEN 0 AND 60 THEN '[51-60]'
	ELSE '[61+]'
END

/* 10 First Letter */
SELECT LEFT(FirstName, 1) AS [FirstLatter]
FROM WizzardDeposits
WHERE DepositGroup = 'Troll Chest'
GROUP BY LEFT(FirstName, 1)

/* 11 Average Interest */
SELECT DepositGroup, IsDepositExpired, AVG(DepositInterest) AS AverageInterest
FROM WizzardDeposits
WHERE DATEPART(YEAR, DepositStartDate) >= 1985
GROUP BY DepositGroup, IsDepositExpired
ORDER BY DepositGroup DESC, IsDepositExpired

/* 12  Rich Wizard, Poor Wizard */
SELECT SUM([Difference]) AS SumDifference FROM (SELECT FirstName AS [Host Wizard],
       DepositAmount AS [Host Wizard Deposit],
	   LEAD(FirstName) OVER(ORDER BY Id) AS [Guest Wizard],
	   LEAD(DepositAmount) OVER(ORDER BY Id) AS [Guest Wizard Deposit],
	   DepositAmount - LEAD(DepositAmount) OVER(ORDER BY Id) AS [Difference]
FROM WizzardDeposits) AS DiffTable

/* 13 Departments Total Salaries */
USE SoftUni

SELECT DepartmentID, SUM(Salary) AS TotalSalary
FROM Employees
GROUP BY DepartmentID

/* 14 Employees Minimum Salaries */
SELECT DepartmentID, MIN(Salary) MinimumSalary
FROM Employees
WHERE DepartmentID IN (2,5,7) AND DATEPART(YEAR, HireDate) >= 2000
GROUP BY DepartmentID

/* 15 Employees Average Salaries */
SELECT *
INTO EmployeesWithHighSalary
FROM Employees
WHERE Salary > 30000

DELETE FROM EmployeesWithHighSalary
WHERE ManagerID = 42

UPDATE EmployeesWithHighSalary
SET Salary += 5000
WHERE DepartmentID = 1

SELECT DepartmentID, AVG(Salary) AS AverageSalary FROM EmployeesWithHighSalary
GROUP BY DepartmentID

/* 16 Employees Maximum Salaries */
SELECT DepartmentID, MAX(Salary) AS MaxSalary
FROM Employees
GROUP BY DepartmentID
HAVING MAX(Salary) NOT BETWEEN 30000 AND 70000

/* 17 Employees Count Salaries */
SELECT COUNT(Salary) AS [COUNT]
FROM Employees
WHERE ManagerID IS NULL

/* 18 3rd Highest Salary */
SELECT DepartmentID, Salary AS [ThirdHighestSalary] FROM 
	(SELECT DepartmentID, Salary, DENSE_RANK() OVER(PARTITION BY DepartmentID ORDER BY Salary DESC) AS [RankTable]
     FROM Employees GROUP BY DepartmentID, Salary) AS [RankTable]
WHERE [RankTable] = 3

/* 19 Salary Challenge */
SELECT TOP(10) FirstName, LastName, DepartmentID
FROM Employees AS e1
WHERE Salary > (
				SELECT AVG(Salary) AS [AvgSalary]
				FROM Employees AS e2
				WHERE e2.DepartmentID = e1.DepartmentID
				GROUP BY DepartmentID
)
ORDER BY e1.DepartmentID

