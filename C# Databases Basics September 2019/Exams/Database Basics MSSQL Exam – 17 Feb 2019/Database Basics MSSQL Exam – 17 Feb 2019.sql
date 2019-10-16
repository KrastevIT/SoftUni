-- 01 DDL --
CREATE DATABASE School

USE School

CREATE TABLE Students (
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(30) NOT NULL,
	MiddleName NVARCHAR(25),
	LastName NVARCHAR(30) NOT NULL,
	Age INT CHECK (Age BETWEEN 5 AND 100),
	[Address] NVARCHAR(60),
	Phone NCHAR(10)
)

CREATE TABLE Subjects (
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(20) NOT NULL,
	Lessons INT CHECK(Lessons > 0) NOT NULL
)

CREATE TABLE StudentsSubjects (
	Id INT PRIMARY KEY IDENTITY,
	StudentId INT FOREIGN KEY REFERENCES Students(Id) NOT NULL,
	SubjectId INT FOREIGN KEY REFERENCES Subjects(Id) NOT NULL,
	Grade DECIMAL(18, 2) CHECK(Grade BETWEEN 2 AND 6) NOT NULL
)

CREATE TABLE Exams (
	Id INT PRIMARY KEY IDENTITY,
	[Date] DATETIME2,
	SubjectId INT FOREIGN KEY REFERENCES Subjects(Id) NOT NULL
)

CREATE TABLE StudentsExams (
	StudentId INT FOREIGN KEY REFERENCES Students(Id) NOT NULL,
	ExamId INT FOREIGN KEY REFERENCES Exams(Id) NOT NULL,
	Grade DECIMAL(18, 2) CHECK(Grade BETWEEN 2 AND 6) NOT NULL,
	CONSTRAINT PK_CompositeStudentIdExamId PRIMARY KEY(StudentId, ExamId)
)

CREATE TABLE Teachers (
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(20) NOT NULL,
	LastName NVARCHAR(20) NOT NULL,
	[Address] NVARCHAR(20) NOT NULL,
	Phone CHAR(10),
	SubjectId INT FOREIGN KEY REFERENCES Subjects(Id) NOT NULL
)

CREATE TABLE StudentsTeachers (
	StudentId  INT FOREIGN KEY REFERENCES Students(Id) NOT NULL,
	TeacherId  INT FOREIGN KEY REFERENCES Teachers(Id) NOT NULL,
	CONSTRAINT PK_CompositeStudentIdTeacherId PRIMARY KEY(StudentId, TeacherId)
)	

-- 02 Insert --
INSERT INTO Teachers(FirstName, LastName, [Address], Phone, SubjectId) VALUES
('Ruthanne', 'Bamb', '84948 Mesta Junction', 3105500146, 6),
('Gerrard',	'Lowin', '370 Talisman Plaza', 3324874824, 2),
('Merrile',	'Lambdin', '81 Dahle Plaza', 4373065154, 5),
('Bert', 'Ivie', '2 Gateway Circle', 4409584510, 4)

INSERT INTO Subjects([Name], Lessons) VALUES
('Geometry', 12),
('Health', 10),
('Drama', 7),
('Sports',9)

-- 03 Update --
UPDATE StudentsSubjects
SET Grade = 6.00
WHERE SubjectId IN (1, 2) AND Grade >= 5.50

--04 Delete --
DELETE FROM StudentsTeachers
WHERE TeacherId IN (SELECT Id FROM Teachers WHERE Phone LIKE '%72%')

DELETE FROM Teachers
WHERE Phone LIKE '%72%'

-- 05 Teen Students --
SELECT s.FirstName, s.LastName, s.Age
FROM Students AS s
WHERE S.Age >= 12
ORDER BY s.FirstName, s.LastName

-- 06 Students Teachers
SELECT s.FirstName, s.LastName, COUNT(s.Id) AS TeachersCount
FROM Students AS s
JOIN StudentsTeachers AS st ON st.StudentId = s.Id
GROUP BY FirstName, s.LastName
 
--07 Students to Go --
SELECT s.FirstName + ' ' + s.LastName AS [Full Name]
FROM Students AS s
LEFT JOIN StudentsExams AS sx ON sx.StudentId = s.Id
WHERE sx.Grade IS NULL
ORDER BY [Full Name]

-- 08 Top Students --
SELECT TOP(10) s.FirstName, s.LastName, CONVERT(DECIMAL(18, 2) ,AVG(sx.Grade)) AS [Grade]  
FROM Students AS s
JOIN StudentsExams AS sx ON sx.StudentId = s.Id
GROUP BY s.FirstName, s.LastName
ORDER BY [Grade] DESC, s.FirstName, s.LastName

-- 09 Not So In The Studying --
SELECT CONCAT(s.FirstName, ' ',s.MiddleName + ' ', s.LastName) AS [Full Name]
FROM Students AS s
LEFT JOIN StudentsSubjects AS ss ON ss.StudentId = s.Id
WHERE ss.SubjectId IS NULL
ORDER BY [Full Name]

-- 10 Average Grade per Subject --
SELECT s.[Name], AVG(sb.Grade) AS AverageGrade
FROM Subjects as s
JOIN StudentsSubjects AS sb ON sb.SubjectId = s.Id
GROUP BY s.Id ,s.[Name]
ORDER BY s.Id

-- 11  Exam Grades --
GO

CREATE FUNCTION udf_ExamGradesToUpdate(@studentId INT, @grade DECIMAL(18, 2))
RETURNS NVARCHAR(MAX)
AS
BEGIN
	DECLARE @firstName NVARCHAR(50) = (SELECT s.FirstName
										   FROM Students s
										   WHERE s.Id = @studentId)

	IF(@firstName IS NOT NULL)
	BEGIN

		DECLARE @currentGrade DECIMAL(18,2) = @grade + 0.50
	
			IF(@grade > 6)
			BEGIN
				RETURN 'Grade cannot be above 6.00!'
			END
		
		DECLARE @count INT = (SELECT COUNT(s.StudentId)
						      FROM StudentsExams AS s
						      GROUP BY s.StudentId, s.Grade
						      HAVING s.StudentId = @studentId AND (s.Grade > @grade AND s.Grade <= (s.Grade + 0.50)))

			RETURN CONCAT('You have to update ', @count, ' grades for the student ', @firstName)
	END

	RETURN 'The student with provided id does not exist in the school!'
END

-- 12 Exclude From School --
CREATE PROC usp_ExcludeFromSchool(@StudentId INT)
AS
DECLARE @studentsMatchingIdCount BIT = (SELECT COUNT(*) FROM Students WHERE Id = @StudentId)

IF(@studentsMatchingIdCount = 0)
BEGIN
	RAISERROR('This school has no student with the provided id!',16,1)
	RETURN
END

DELETE FROM StudentsTeachers
WHERE StudentId = @StudentId

DELETE FROM StudentsExams
WHERE StudentId = @StudentId

DELETE FROM StudentsSubjects
WHERE StudentId = @StudentId

DELETE FROM Students
WHERE Id = @StudentId
