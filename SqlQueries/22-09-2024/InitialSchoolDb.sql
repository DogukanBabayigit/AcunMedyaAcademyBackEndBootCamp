--VERİ TABANI YARATMA

USE master

DROP DATABASE IF EXISTS OKUL
--EĞER OKUL DİYE BİR DATABASE VARSA SİLER.

CREATE DATABASE OKUL

USE OKUL

--vERİ TABANI YARATMA BİTTİ

--TABLOLARI YARATMA İŞLEMİ BAŞLIYOR

CREATE TABLE Majors
(
    MajorID INT PRIMARY KEY IDENTITY (1,1),
    MajorName NVARCHAR (50) NOT NULL,
)

CREATE TABLE Lessons
(
    LessonID INT PRIMARY KEY IDENTITY (1,1),
    LessonName NVARCHAR(100) NOT NULL,
    Credit TINYINT NOT NULL,
    MajorID INT NOT NULL,
    FOREIGN KEY (MajorID) REFERENCES Majors(MajorID)

)

CREATE TABLE Students
(
    StudentID INT PRIMARY KEY IDENTITY(1,1),
    StudentName NVARCHAR(50) NOT NULL,
    StudentSurname NVARCHAR(50) NOT NULL,
    BirtDate DATE NULL,
    MajorID INT NOT NULL,
    FOREIGN KEY (MajorID) REFERENCES Majors(MajorID)

)

CREATE TABLE LessonsSaves
(
    StudentID INT ,
    LessonsID INT ,
    FOREIGN KEY( StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (LessonsID) REFERENCES Lessons (LessonID)
)

--TABLOLARI YARATMA İŞLEMİ BİTTİ

--VERİ EKLEME İŞLEMİ BAŞLIYOR

INSERT INTO  Majors
    (MajorName)
VALUES
    ('Bilgisayar Mühendisliği'),
    ('Hukuk'),
    ('Mekatronik Mühendisliği')

INSERT INTO Lessons
    (MajorID,LessonName,Credit)
VALUES
    (1, 'Temel Programlama', 4),
    (1, 'Temel Elektronik', 6),
    (1, 'Yapay Zekaya Giriş', 8),
    (2, 'Temel Hukuk', 6),
    (2, 'Anayasa Hukuk', 10),
    (3, 'Malzeme Bilimi', 3)

INSERT INTO Students
    (MajorID,StudentName,StudentSurname,BirtDate)
VALUES
    (1, 'Alican', 'Kintutar', '2000-05-19'),
    (1, 'Seden', 'Serdengeçen', '1998-06-12'),
    (2, 'Candan', 'Tutankaçan', '1985-03-19'),
    (3, 'Kemal', 'Evrim', '1996-07-16')

INSERT INTO LessonsSaves
    (StudentID,LessonsID)
VALUES

    (1, 1),
    (1, 2),
    (1, 3),

    (2, 3),

    (3, 4),
    (3, 5),

    (4, 6)
    
-- VERİ EKLEME İŞİ BİTTİ