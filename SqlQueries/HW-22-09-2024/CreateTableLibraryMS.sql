USE LibraryManagmentSystem

/* CREATE TABLE Books(   

    BookId INT PRIMARY KEY IDENTITY (1,1),
    BookName NVARCHAR (50) NOT NULL,
    Writer NVARCHAR (50) NOT NULL,
    PublishDate DATE NULL,
    NumberOfPages INT NOT NULL,
    ISBN NVARCHAR NOT NULL,
)

CREATE TABLE Magazines(

    MagazineId INT PRIMARY KEY IDENTITY (1,1),
    MagazineName NVARCHAR(50) NOT NULL,
    Publisher NVARCHAR(50),
    PublishDate DATETIME NULL,
    NumberOfPages INT NOT NULL,
)

CREATE TABLE DVDs(

    DvdId INT PRIMARY KEY IDENTITY (1,1),
    DvdName NVARCHAR (50) NOT NULL,
    Director NVARCHAR(50) NOT NULL,
    ReleaseDate DATE NOT NULL,
    Duration INT NOT NULL,

)

CREATE TABLE Students(

    StudentID INT PRIMARY KEY IDENTITY(1,1),
    StudentName NVARCHAR (50) NOT NULL,
    StudentSurname NVARCHAR (50) NOT NULL,
    BirthDate DATE NULL,
) */

CREATE TABLE BorrowTable(
    StudentID INT,
    BookId INT,
    MagazineId INT,
    DvdId INT,
    BorrowTime DATETIME,

    FOREIGN KEY (StudentId) REFERENCES Students(StudentID),
    FOREIGN KEY (BookId) REFERENCES Books(BookId),
    FOREIGN KEY (MagazineId) REFERENCES Magazines(MagazineId),
    FOREIGN KEY (DvdId) REFERENCES DVDs(DvdId),
)