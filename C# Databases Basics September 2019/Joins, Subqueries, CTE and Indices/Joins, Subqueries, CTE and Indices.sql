/* 01 Employee Address */
USE SoftUni

SELECT TOP(5) EmployeeID, JobTitle, A.AddressID, A.AddressText
FROM Employees AS emp
INNER JOIN Addresses AS a
ON emp.AddressID = A.AddressID
ORDER BY A.AddressID


/* 02 Addresses with Towns */
SELECT TOP(50) e.FirstName, e.LastName, t.[Name], a.AddressText 
FROM Employees AS e
JOIN Addresses a
ON e.AddressID = a.AddressID
JOIN Towns AS t
ON a.TownID = t.TownID
ORDER BY e.FirstName, e.LastName ASC

/* 03 Sales Employees */
SELECT e.EmployeeID, e.FirstName, e.LastName, d.[Name] AS DepartmentName
FROM Employees AS e
JOIN Departments AS d
ON e.DepartmentID = d.DepartmentID
WHERE D.[Name] = 'Sales'
ORDER BY e.EmployeeID ASC

/* 04 Employee Departments */
SELECT TOP(5) e.EmployeeID, e.FirstName, e.Salary, d.[Name] AS DepartmentName
FROM Employees AS e
JOIN Departments AS d
ON e.DepartmentID = d.DepartmentID
WHERE e.Salary > 15000
ORDER BY d.DepartmentID ASC

/* 05 Employees Without Projects */
SELECT TOP(3) e.EmployeeID, e.FirstName
FROM Employees AS e
LEFT JOIN EmployeesProjects as emp
ON e.EmployeeID = emp.EmployeeID
WHERE emp.EmployeeID IS NULL
ORDER BY emp.EmployeeID ASC

/* 06 Employees Hired After */
SELECT e.FirstName, e.LastName, e.HireDate, d.Name AS DeptName
FROM Employees AS e
JOIN Departments AS d
ON d.DepartmentID = e.DepartmentID
WHERE e.HireDate > '01.01.1999' AND d.[Name] IN ('Sales', 'Finance')
ORDER BY e.HireDate ASC  

/* 07 Employees With Project */
SELECT TOP(5) e.EmployeeID, e.FirstName, p.[Name] AS ProjectName
FROM Employees AS e
JOIN EmployeesProjects AS ep
ON ep.EmployeeID = e.EmployeeID
JOIN Projects AS p
ON ep.ProjectID = P.ProjectID
WHERE p.StartDate > '08.13.2002' AND P.EndDate IS NULL
ORDER BY E.EmployeeID

/* 08 Employee 24 */
SELECT e.EmployeeID, e.FirstName,
	IIF(pro.StartDate <= '01.01.2005',pro.[Name], NULL)
FROM Employees AS e
JOIN EmployeesProjects AS ep
ON ep.EmployeeID = e.EmployeeID
JOIN Projects AS pro
ON pro.ProjectID = ep.ProjectID
WHERE ep.EmployeeID = 24

/* 09 Employee Manager */
SELECT e.EmployeeID, e.FirstName, e.ManagerID, e2.FirstName AS ManagerName
FROM Employees AS e
JOIN Employees AS e2
ON e2.EmployeeID = e.ManagerID
WHERE e.ManagerID = 3 OR e.ManagerID = 7
ORDER BY E.EmployeeID

/* 10 Employees Summary */
SELECT TOP(50) emp.EmployeeID, 
		CONCAT(emp.FirstName, ' ', emp.LastName) AS EmployeeName,
		CONCAT(mng.FirstName, ' ', mng.LastName) AS ManagerName,
		d.[Name] AS DepartmentName
	FROM Employees	AS emp
	JOIN Employees AS mng
	ON mng.EmployeeID = emp.ManagerID
	JOIN Departments AS d
	ON d.DepartmentID = emp.DepartmentID
	ORDER BY emp.EmployeeID  

/* 11 Min Average Salary */
SELECT MIN(AverageSalaryByDepartment) AS MinAverageSalary 
FROM (SELECT AVG(Salary) AS AverageSalaryByDepartment 
FROM Employees
GROUP BY DepartmentID) AS AvgSalaries

/* 12 Highest Peaks in Bulgaria */
USE Geography

SELECT c.CountryCode, m.MountainRange, p.PeakName, p.Elevation
FROM Countries AS c
JOIN MountainsCountries AS mc ON mc.CountryCode = c.CountryCode
JOIN Mountains AS m ON m.Id = mc.MountainId
JOIN Peaks AS p ON p.MountainId = m.Id
WHERE c.CountryCode = 'BG' AND P.Elevation > 2835
ORDER BY P.Elevation DESC

/* 13 Count Mountain Ranges */
SELECT CountryCode, COUNT(MountainId) AS MountainRanges
FROM  MountainsCountries
WHERE CountryCode IN ('US', 'RU', 'BG')
GROUP BY CountryCode

/* 14 Countries With or Without Rivers */
SELECT TOP(5) c.CountryName, r.RiverName
FROM Countries AS c
LEFT JOIN CountriesRivers AS cr ON cr.CountryCode = c.CountryCode
LEFT JOIN Rivers AS r ON r.Id = cr.RiverId
WHERE c.ContinentCode = 'AF'
ORDER BY c.CountryName 

/* 15 Continents and Currencies */
SELECT k.ContinentCode, k.CurrencyCode, k. CountOfCurrency
	FROM (
	SELECT  c.ContinentCode,
			c.CurrencyCode,
			COUNT(c.CurrencyCode) AS CountOfCurrency,
			DENSE_RANK() OVER (PARTITION BY c.ContinentCode ORDER BY COUNT(c.CurrencyCode) DESC) AS CurrencyRank
FROM Countries AS c
GROUP BY c.ContinentCode , c.CurrencyCode
HAVING COUNT(c.CurrencyCode) > 1) AS k
WHERE k.CurrencyRank = 1
ORDER BY k.ContinentCode

/* 16 Countries Without any Mountains */
SELECT COUNT(*)
FROM Countries AS c
LEFT JOIN MountainsCountries AS mc ON mc.CountryCode = c.CountryCode
WHERE mc.MountainId IS NULL

/* 17 Highest Peak and Longest River by Country */
SELECT TOP(5) c.CountryName, 
		MAX(p.Elevation) AS HighestPeakElevation,
		MAX(r.[Length]) AS LongestRiverLength
FROM Countries AS c
LEFT JOIN MountainsCountries AS mc ON mc.CountryCode = c.CountryCode
LEFT JOIN Mountains AS m ON m.Id = mc.MountainId
LEFT JOIN Peaks AS p ON p.MountainId = mc.MountainId
LEFT JOIN CountriesRivers AS cr ON cr.CountryCode = c.CountryCode
LEFT JOIN Rivers AS r ON r.Id = cr.RiverId
GROUP BY c.CountryName
ORDER BY HighestPeakElevation DESC, LongestRiverLength DESC, c.CountryName

/* 18 Highest Peak Name and Elevation by Country */
