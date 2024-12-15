USE OKUL

CREATE TABLE Majors(
    MajorID INT PRIMARY KEY IDENTITY (1,1),
    MajorName NVARCHAR (50) NOT NULL,
    ) 

CREATE TABLE Lessons (
    LessonID INT PRIMARY KEY IDENTITY (1,1),
    LessonName NVARCHAR(100) NOT NULL,
    Credit TINYINT NOT NULL,
    MajorID INT NOT NULL,
    FOREIGN KEY (MajorID) REFERENCES Majors(MajorID)

)

CREATE TABLE Students (
    StudentID INT PRIMARY KEY IDENTITY(1,1),
    StudentName NVARCHAR(50) NOT NULL,
    StudentSurname NVARCHAR(50) NOT NULL,
    BirtDate DATE NULL,
    MajorID INT NOT NULL,
    FOREIGN KEY (MajorID) REFERENCES Majors(MajorID)

)

CREATE TABLE LessonsSaves(
    StudentID INT , 
    LessonsID INT ,
    FOREIGN KEY( StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (LessonsID) REFERENCES Lessons (LessonID)
)