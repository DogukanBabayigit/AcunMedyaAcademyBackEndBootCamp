-- CREATE TABLE Staffs(
--     StaffId INT PRIMARY KEY IDENTITY (1,1),
--     StaffName NVARCHAR (50) NOT NULL,
--     Surname NVARCHAR (50) NOT NULL,
--     JobPosition NVARCHAR (50) NOT NULL,
--     StartDate DATE NOT NULL
-- )

-- CREATE TABLE Payments(
--     PaymentId INT PRIMARY KEY IDENTITY (1,1),
--     StaffId INT NULL,
--     PaymentAmount INT NOT NULL,
--     UpdatedDate DATE
-- )

-- INSERT INTO Staffs
-- (StaffName,Surname,JobPosition,StartDate)
-- VALUES
-- ('Ayşe','Demir','Okul Müdürü','2021-09-05'),
-- ('Mehmet Ali','Kaya','Müdür Yardımcısı','2021-09-15'),
-- ('Zeynep','Çetin','Sınıf Öğretmeni','2021-09-07'),
-- ('Fatma','Özdemir','Biyoloji Öğretmeni','2021-11-10'),
-- ('Mehmet','Yılmaz','Matematik Öğretmeni','2021-10-05'),
-- ('Ayşe Gül','Ersoy','Türkçe Öğretmeni','2021-10-15'),
-- ('Burcu','Şahin','Rehber Öğretmen','2022-02-13'),
-- ('Elif','Güven','Okul Sekreteri','2021-08-31'),
-- ('Mehmet Ali','Kurtulan','Teknik Personel','2021-09-27'),
-- ('Fatma','Yılmaz','Temizlik Personeli','2021-08-31'),
-- ('Kamil','Kandıracı','Kantinci','2021-10-22')