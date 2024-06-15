CREATE DATABASE ProjectEvaluation;

USE ProjectEvaluation;

CREATE TABLE AdminList(
	[Admin User ID] INT PRIMARY KEY,
	[Admin Username] VARCHAR(255),
	[Admin Password] VARCHAR(MAX)
);

CREATE TABLE StudentList(
	[Student User ID] INT PRIMARY KEY IDENTITY(1,1),
	[Student Number] VARCHAR(255),
	[First Name] VARCHAR(500),
	[Last Name] VARCHAR(500),
	[Student Password] VARCHAR(MAX)
);

CREATE TABLE Response1(
	[Student User ID] INT,
	[First Name] VARCHAR(255),
	[Last Name] VARCHAR(255),
	Age VARCHAR(255),
	[Year Level] VARCHAR(255),
	[Student Status] VARCHAR(255),
	[Year Level Option 1] VARCHAR(255),
	[Year Level Option 2] VARCHAR(255),
	[Year Level Option 3] VARCHAR(255),
	[Work Status] VARCHAR(255),
	Answer1 VARCHAR(50),
	Answer2 VARCHAR(50),
	Answer3 VARCHAR(50),
	Answer4 VARCHAR(50),
	Answer5 VARCHAR(50),
	Answer6 VARCHAR(50)
	FOREIGN KEY ([Student User ID]) REFERENCES StudentList([Student User ID])
);

CREATE TABLE Response2(
	[Student User ID] INT,
	[First Name] VARCHAR(255),
	[Last Name] VARCHAR(255),
	Age VARCHAR(255),
	[Year Level] VARCHAR(255),
	[Student Status] VARCHAR(255),
	[Year Level Option 1] VARCHAR(255),
	[Year Level Option 2] VARCHAR(255),
	[Year Level Option 3] VARCHAR(255),
	[Work Status] VARCHAR(255),
	Answer1 VARCHAR(50),
	Answer2 VARCHAR(50),
	Answer3 VARCHAR(50),
	FOREIGN KEY ([Student User ID]) REFERENCES StudentList([Student User ID])
);

INSERT INTO StudentList([Student Number], [Student Password], [First Name], [Last Name]) 
VALUES
	('beralde.312236@stamesa.sti.edu.ph','student123123', 'Benedict','Beralde'),
	('fernan.111111@stamesa.sti.edu.ph','student123123', 'Jos', 'Fernan'),
	('biblanas.222222@stamesa.sti.edu.ph','student123123', 'Renielyn', 'Biblanas'),
	('polido.333333@stamesa.sti.edu.ph','student123123', 'Rica', 'Polido'),
	('tiu.444444@stamesa.sti.edu.ph','student123123', 'John', 'Tiu');


INSERT INTO AdminList([Admin User ID],[Admin Username], [Admin Password]) 
VALUES(1,'adminBen','admin123123'),
(2,'adminJos','admin123123'),
(3,'adminRen','admin123123'),
(4,'adminRica','admin123123'),
(5,'adminTiu','admin123123');

SELECT * FROM StudentList;
SELECT * FROM AdminList;

--Optional UPDATE of User ID
DBCC CHECKIDENT ('StudentList', RESEED, 1);
DBCC CHECKIDENT ('AdminList', RESEED, 1);

--Optional UPDATE of USER ID
UPDATE AdminList
SET [Admin User ID] = 1
WHERE [Admin Username] = 'adminBen';

SELECT * FROM Response1;
SELECT * FROM Response2;

DELETE FROM  StudentList
WHERE [Student User ID] = 1;

DROP TABLE StudentList;
DROP TABLE Response1;
DROP TABLE Response2;

DROP TABLE AdminList;

DELETE FROM AdminList
WHERE [Admin Username] = 'admin';
