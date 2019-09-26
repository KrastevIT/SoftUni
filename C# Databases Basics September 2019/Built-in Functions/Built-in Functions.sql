-- 01 Find Names of All Employees by First Name 
USE SoftUni

SELECT FirstName, LastName
	FROM Employees
	WHERE FirstName LIKE 'SA%'

-- 02 Find Names of All Employees by Last Name 
SELECT FirstName, LastName
	FROM Employees
	WHERE LastName LIKE '%ei%'

-- 03 Find First Names of All Employess
SELECT FirstName
	FROM Employees
	WHERE DepartmentID IN (3,10) AND DATEPART(YEAR, HireDate) BETWEEN 1995 AND 2005

-- 04 Find All Employees Except Engineers

SELECT FirstName, LastName
	FROM Employees
	WHERE JobTitle NOT LIKE '%engineer%'

-- 05 Find Towns with Name Length
SELECT [Name]
	FROM Towns
	WHERE LEN([Name]) IN(5, 6)
	ORDER BY [Name]

--06 Find Towns Starting With
SELECT [TownID], [Name]
	FROM Towns
	WHERE [Name] LIKE '[MKBE]%'
	ORDER BY [Name]

--07 Find Towns Not Starting With
SELECT [TownID], [Name]
	FROM Towns
	WHERE [Name] NOT LIKE '[RBD]%'
	ORDER BY [Name]

--08 Create View Employees Hired After
CREATE VIEW V_EmployeesHiredAfter2000 AS 
	SELECT [FirstName], [LastName] FROM Employees 
	WHERE DATEPART(YEAR, HireDate) > 2000

--09 Length of Last Name
SELECT FirstName, LastName
	FROM Employees
	WHERE LEN(LastName) IN(5)

--10 Rank Employees by Salary
SELECT EmployeeID , FirstName, LastName, Salary,
	DENSE_RANK() OVER(PARTITION BY Salary ORDER BY EmployeeId) AS [Rank]
	FROM Employees
	WHERE Salary BETWEEN 10000 AND 50000
	ORDER BY Salary DESC

--11 Find All Employees with Rank 2
SELECT * FROM (SELECT EmployeeID , FirstName, LastName, Salary,
	DENSE_RANK() OVER(PARTITION BY Salary ORDER BY EmployeeId) AS [Rank]
	FROM Employees
	WHERE Salary BETWEEN 10000 AND 50000) AS temp
	WHERE temp.[Rank] = 2
	ORDER BY TEMP.Salary DESC

--12 Countries Holding 'A'
USE Geography

SELECT CountryName, IsoCode FROM Countries
	WHERE CountryName LIKE '%A%A%A%'
	ORDER BY IsoCode

--13 Mix of Peak and River Names
SELECT p.PeakName, r.RiverName, LOWER(CONCAT(LEFT(p.PeakName, LEN(p.PeakName) -1), r.RiverName)) AS [Mix]
FROM Peaks AS p
JOIN Rivers AS r ON RIGHT(p.PeakName, 1) = LEFT(r.RiverName, 1) 
ORDER BY Mix

--14 Games From 2011 and 2012 Year
USE Diablo

SELECT TOP(50) [Name], FORMAT([Start], 'yyyy-MM-dd') AS [Start] FROM Games
		WHERE DATEPART(YEAR, [Start]) BETWEEN 2011 AND 2012
		ORDER BY [Start], [Name]

--15 User Email Providers
SELECT Username, SUBSTRING(Email, CHARINDEX('@', Email, 1) + 1, LEN(Email)) AS [Email Provider] FROM Users
ORDER BY [Email Provider], Username

--16 Get Users with IPAddress Like Pattern
SELECT Username, IpAddress AS [IP Address] FROM Users
WHERE IpAddress LIKE '___.1_%._%.___'
ORDER BY Username

--17 Show All Games with Duration
SELECT [Name] AS [Game],
CASE
	WHEN DATEPART(HOUR, [Start]) BETWEEN 0 AND 11 THEN 'Morning'
	WHEN DATEPART(HOUR, [Start]) BETWEEN 12 AND 17 THEN 'Afternoon'
	ELSE 'Evening'
END AS [Part of the Day],
CASE
	WHEN Duration <= 3 THEN 'Extra Short'
	WHEN Duration BETWEEN 4 AND 6 THEN 'Short'
	WHEN Duration > 6 THEN 'Long'
	WHEN Duration IS NULL THEN 'Extra Long'
END AS [Duration]
FROM Games
ORDER BY [Game], [Duration], [Part of the Day]

--18 Orders Table
USE Orders

SELECT ProductName, OrderDate, DATEADD(DAY, 3, OrderDate) AS [Pay Due], DATEADD(MONTH, 1, OrderDate) AS [Deliver Due] 
FROM Orders



