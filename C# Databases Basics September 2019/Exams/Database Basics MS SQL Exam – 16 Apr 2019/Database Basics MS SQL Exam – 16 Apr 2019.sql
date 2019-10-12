-- 01 DDL --
CREATE DATABASE Airport

USE Airport

CREATE TABLE Planes (
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(30) NOT NULL,
	Seats INT NOT NULL,
	[Range] INT NOT NULL
)

CREATE TABLE Flights  (
	Id INT PRIMARY KEY IDENTITY,
	DepartureTime DATETIME2,
	ArrivalTime DATETIME2,
	Origin VARCHAR(50) NOT NULL,
	Destination VARCHAR(50) NOT NULL,
	PlaneId INT FOREIGN KEY REFERENCES Planes(Id) NOT NULL
)

CREATE TABLE Passengers (
	Id INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(30) NOT NULL,
	LastName VARCHAR(30) NOT NULL,
	Age INT NOT NULL,
	[Address] VARCHAR(30) NOT NULL,
	PassportId CHAR(11) NOT NULL
)

CREATE TABLE LuggageTypes  (
	Id INT PRIMARY KEY IDENTITY,
	[Type] VARCHAR(30) NOT NULL
)

CREATE TABLE Luggages (
	Id INT PRIMARY KEY IDENTITY,
	LuggageTypeId INT FOREIGN KEY REFERENCES LuggageTypes(Id) NOT NULL,
	PassengerId INT FOREIGN KEY REFERENCES Passengers(Id) NOT NULL
)

CREATE TABLE Tickets (
	Id INT PRIMARY KEY IDENTITY,
	PassengerId INT FOREIGN KEY REFERENCES Passengers(Id) NOT NULL,
	FlightId INT FOREIGN KEY REFERENCES Flights(Id) NOT NULL,
	LuggageId INT FOREIGN KEY REFERENCES Luggages(Id) NOT NULL,
	Price DECIMAL(18, 2) NOT NULL
)

-- 02 Insert --
INSERT INTO Planes([Name], Seats,Range) VALUES
('Airbus 336', 112,	5132),
('Airbus 330', 432, 5325),
('Boeing 369', 231, 2355),
('Stelt 297', 254, 2143),
('Boeing 338', 165, 5111),
('Airbus 558', 387, 1342),
('Boeing 128', 345, 5541)

INSERT INTO LuggageTypes(Type) VALUES
('Crossbody Bag'),
('School Backpack'),
('Shoulder Bag')

-- 03 Update --
UPDATE Tickets
SET Price += Price * 0.13
WHERE FlightId IN (SELECT Id FROM Flights
				   WHERE Destination = 'Carlsbad')

--* 04 Delete --
DELETE FROM Tickets
WHERE FlightId IN (SELECT Id FROM Flights
				   WHERE Destination = 'Ayn Halagim')

DELETE FROM Flights
WHERE Destination = 'Ayn Halagim'
				 
-- 05 The "Tr" Planes --
SELECT *
FROM Planes
WHERE [Name] LIKE '%tr%'
ORDER BY Id, [Name], Seats, [Range]

-- 06 Flight Profits --
SELECT t.FlightId, SUM(t.Price) AS Price
FROM Tickets AS t
GROUP BY t.FlightId
ORDER BY SUM(t.Price) DESC, t.FlightId

-- 07 Passenger Trips --
SELECT p.FirstName + ' ' + p.LastName AS [Full Name], f.Origin, f.Destination
FROM Passengers AS p
JOIN Tickets AS t ON t.PassengerId = p.Id
JOIN Flights AS f ON f.Id = t.FlightId
ORDER BY [Full Name], f.Origin, f.Destination

-- 08 Non Adventures People --
SELECT p.FirstName, p.LastName, p.Age
FROM Passengers AS p
LEFT JOIN Tickets AS t ON t.PassengerId = p.Id
WHERE t.Id IS NULL
ORDER BY p.Age DESC, p.FirstName, p.LastName

-- 09 Full Info 
SELECT (p.FirstName + ' ' + p.LastName) AS [FullName], pL.[Name], (f.Origin + ' - ' + f.Destination) AS [Trip], lt.[Type] AS [Luggage Type]
FROM Passengers p
JOIN Tickets AS t ON t.PassengerId = p.Id
LEFT JOIN Flights AS f ON f.Id = t.FlightId
JOIN Planes AS pL ON pl.Id = f.PlaneId
JOIN Luggages AS l ON l.Id = t.LuggageId
JOIN LuggageTypes AS lt ON lt.Id = l.LuggageTypeId
WHERE f.Id IS NOT NULL
ORDER BY [FullName], pl.[Name], f.Origin, f.Destination, lt.Type 

-- 10 PSP --
SELECT p.[Name], p.Seats, COUNT(t.Id) AS [Passengers Count]
FROM Planes p
LEFT OUTER JOIN Flights AS f ON f.PlaneId = p.Id
LEFT OUTER JOIN Tickets AS t ON t.FlightId = f.Id
GROUP BY p.[Name], p.Seats
ORDER BY [Passengers Count] DESC, p.[Name], p.Seats 
 
 -- 11 Vacation --
 GO

 CREATE FUNCTION udf_CalculateTickets(@origin VARCHAR(50), @destination VARCHAR(50), @peopleCount INT)
 RETURNS VARCHAR(50)
 AS
 BEGIN
	IF(@peopleCount <= 0)
	BEGIN
		RETURN 'Invalid people count!'
	END

	DECLARE @flightId INT = (SELECT TOP(1) Id FROM Flights
							 WHERE Origin = @origin AND Destination = @destination)

	IF(@flightId IS NULL)
	BEGIN
		RETURN 'Invalid flight!'
	END

	DECLARE @pricePerPerson DECIMAL(18, 2) = (SELECT TOP(1) Price FROM Tickets AS t
											  WHERE t.FlightId = @flightId)
	DECLARE @TotalPrice DECIMAL(24, 2) = @pricePerPerson * @peopleCount

	RETURN CONCAT('Total price ', @totalPrice)
 END
 
 -- 12 Wrong Data --
 GO

CREATE PROC usp_CancelFlights
AS
UPDATE Flights
SET DepartureTime = NULL, ArrivalTime = NULL
WHERE DATEDIFF(SECOND, DepartureTime, ArrivalTime) > 0