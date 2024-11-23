--Veri tabanı oluşturma operasyonu
use master
go

if exists (select * from sys.databases where name = 'LearnifyStockAppDb')
begin
    alter database LearnifyStockAppDb set single_user with rollback immediate
    drop database LearnifyStockAppDb
end
go

create database LearnifyStockAppDb
go

use LearnifyStockAppDb
go

-- Categories tablosu
create table Categories(
    Id int primary key identity,
    Name nvarchar(max) not null,
    Description nvarchar(max) not null,
    IsDeleted bit not null default 0,
    CreatedAt datetime2(3) not null default getdate(),
    UpdatedAt datetime2(3)
)
go

-- Suppliers tablosu
create table Suppliers(
    Id int primary key identity,
    Name nvarchar(max) not null,
    Contact nvarchar(max) not null,
    Email nvarchar(max) not null,
    PhoneNumber nvarchar(max) not null,
    Address nvarchar(max),
    City nvarchar(max) not null,
    Country nvarchar(max) not null,
    IsDeleted bit not null default 0,
    CreatedAt datetime2(3) not null default getdate(),
    UpdatedAt datetime2(3)
)
go

-- Products tablosu
create table Products(
    Id int primary key identity,
    Name nvarchar(max) not null,
    Description nvarchar(max) not null,
    CategoryId int not null,
    SupplierId int not null,
    StockQuantity int not null default 0,
    MinimumStockLevel int not null default 1,
    Price decimal(10,2) not null,
    IsDeleted bit not null default 0,
    CreatedAt datetime2(3) not null default getdate(),
    UpdatedAt datetime2(3),
    constraint FK_Products_Categories foreign key (CategoryId) references Categories(Id),
    constraint FK_Products_Suppliers foreign key (SupplierId) references Suppliers(Id),
    constraint CHK_Products_StockQuantity check (StockQuantity>=0),
    constraint CHK_Products_MinimumStockLevel check(MinimumStockLevel>=1),
    constraint CHK_Products_Price check (Price>=0)
)
go

-- TransactionTypes tablosu
create table TransactionTypes(
    Id int primary key identity,
    Name nvarchar(max) not null,
    IsDeleted bit not null default 0,
    CreatedAt datetime2(3) not null default getdate(),
    UpdatedAt datetime2(3)
)
go
-- 1 'Giriş'
-- 2 'Çıkış'

--StockTransactions tablosu
create table StockTransactions(
    Id int primary key identity,
    ProductId int not null,
    TransactionTypeId int not null,
    TransactionDate datetime not null default getdate(),
    Quantity int not null default 1,
    Note nvarchar(max),
    IsDeleted bit not null default 0,
    constraint FK_StockTransactions_Products foreign key (ProductId) references Products(Id),
    constraint FK_StockTransactions_TransactionTypes foreign key (TransactionTypeId) references TransactionTypes(Id),
    constraint CHK_StockTransactions_Quantity check (Quantity>0)
)
go

--Customers tablosu
create table Customers(
    Id int primary key identity,
    Name nvarchar(max) not null,
    Contact nvarchar(max) not null,
    Email nvarchar(max) not null,
    PhoneNumber nvarchar(max) not null,
    Address nvarchar(max),
    City nvarchar(max) not null,
    Country nvarchar(max) not null,
    IsDeleted bit not null default 0,
    CreatedAt datetime2(3) not null default getdate(),
    UpdatedAt datetime2(3)
)
go

-- Sales tablosu
create table Sales(
    Id int primary key identity,
    ProductId int not null,
    CustomerId int not null,
    Quantity int not null,
    UnitPrice decimal(10,2) not null,
    SaleDate datetime2(3) not null default getdate(),
    IsDeleted bit not null default 0
)
go