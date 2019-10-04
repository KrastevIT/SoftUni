/* 01 One-To-One Relationship */
CREATE DATABASE TableRelationExercise

USE TableRelationExercise


CREATE TABLE Passports (
	PassportID INT PRIMARY KEY,
	PassportNumber NVARCHAR(100)
)

CREATE TABLE Persons (
	PersonID INT PRIMARY KEY,
	FirstName NVARCHAR(50),
	Slary DECIMAL(7,2),
	PassportID INT UNIQUE,
	CONSTRAINT FK_Persons_Passports FOREIGN KEY
	(PassportID) REFERENCES Passports(PassportID)
)

/* 02 One-To-Many Relationship */
CREATE TABLE Manufacturers (
	ManufacturerID INT PRIMARY KEY IDENTITY,
	Name VARCHAR(30) NOT NULL,
	EstablishedOn DATE
)

CREATE TABLE Models (
	ModelID INT PRIMARY KEY IDENTITY(101, 1),
	Name VARCHAR(30) NOT NULL,
	ManufacturerID INT FOREIGN KEY REFERENCES Manufacturers(ManufacturerID)
)

INSERT INTO Manufacturers VALUES
('BMW', '1916-03-07'),
('Tesla', '2003-01-01'),
('Lada', '1966-05-01')

INSERT INTO Models VALUES
('X1', 1),
('i6', 1),
('Model S', 2),
('Model X', 2),
('Model 3', 2),
('Nova', 3)

/* 03 Many-To-Many Relationship */
CREATE TABLE Students (
	StudentID INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(50) NOT NULL
)

CREATE TABLE Exams (
	ExamID INT PRIMARY KEY,
	[Name] NVARCHAR(50)
)

CREATE TABLE StudentsExams (
	StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
	ExamID INT FOREIGN KEY REFERENCES Exams(ExamID),
	CONSTRAINT PK_Students_Exams PRIMARY KEY(StudentID, ExamID)
)

INSERT INTO Students([Name])
VALUES
	('Mila'),
	('Toni'),
	('Ron')

INSERT INTO Exams(ExamID, [Name])
VALUES
	(101, 'SpringMVC'),
	(102, 'Neo4j'),
	(103, 'Oracle 11g')

INSERT INTO StudentsExams(StudentID, ExamID)
VALUES
	(1, 101),
	(1, 102),
	(2, 101),
	(3, 103),
	(2, 102),
	(2, 103)

/* 04 Self-Referencing */
CREATE TABLE Teachers (
	TeacherID INT PRIMARY KEY IDENTITY(101, 1),
	Name VARCHAR(50) NOT NULL,
	ManagerID INT FOREIGN KEY REFERENCES Teachers(TeacherID)
)

INSERT INTO Teachers VALUES
('John', NULL),
('Maya', NULL),
('Silvia', NULL),
('Ted', NULL),
('Mark', 101),
('Greta', 101)

/* 05 Online Store Database */
CREATE DATABASE OnlineStore

USE OnlineStore

CREATE TABLE Cities (
	CityID INT PRIMARY KEY NOT NULL,
	[Name] VARCHAR(50) NOT NULL
)

CREATE TABLE Customers (
	CustomerID INT PRIMARY KEY  NOT NULL,
	[Name] VARCHAR(50) NOT NULL,
	Birthday DATE,
	CityID INT FOREIGN KEY REFERENCES Cities(CityID) NOT NULL
)

CREATE TABLE Orders (
	OrderID INT PRIMARY KEY NOT NULL,
	CustomerID INT FOREIGN KEY REFERENCES Customers(CustomerID) NOT NULL
)

CREATE TABLE ItemTypes (
	ItemTypeID INT PRIMARY KEY NOT NULL,
	[Name] VARCHAR(50) NOT NULL
)

CREATE TABLE Items (
	ItemID INT PRIMARY KEY NOT NULL,
	[Name] VARCHAR(50) NOT NULL,
	ItemTypeID INT FOREIGN KEY REFERENCES ItemTypes(ItemTypeID) NOT NULL
)


CREATE TABLE OrderItems (
	OrderID INT FOREIGN KEY REFERENCES Orders(OrderID),
	ItemID INT FOREIGN KEY REFERENCES Items(ItemID)
	CONSTRAINT PK_Order_Items PRIMARY KEY (OrderID, ItemID)
)

/* 06 University Database */
CREATE DATABASE University
USE University 

CREATE TABLE Majors (
	MajorID INT PRIMARY KEY,
	[Name] VARCHAR(50)
)
CREATE TABLE Students (
	StudentID INT PRIMARY KEY,
	StudentNumber INT,
	StudentName VARCHAR(50),
	MajorID INT FOREIGN KEY REFERENCES Majors(MajorID)
)

CREATE TABLE Payments (
	PaymentID INT PRIMARY KEY,
	PaymentDate DATE,
	PaymentAmount DECIMAL(6,2),
	StudentID INT FOREIGN KEY REFERENCES Students(StudentID)
)

CREATE TABLE Subjects (
	SubjectID INT PRIMARY KEY,
	SubjectName VARCHAR(50)
)

CREATE TABLE Agenda (
	StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
	SubjectID INT  FOREIGN KEY REFERENCES Subjects(SubjectID)
	CONSTRAINT PK_Student_Subject PRIMARY KEY (StudentID, SubjectID)
)

/* 09 Peaks in Rila */
USE Geography

SELECT M.MountainRange, P.PeakName, P.Elevation
FROM Peaks AS p
JOIN Mountains AS m
ON p.MountainId = m.Id
WHERE m.MountainRange = 'Rila'
ORDER BY p.Elevation DESC
