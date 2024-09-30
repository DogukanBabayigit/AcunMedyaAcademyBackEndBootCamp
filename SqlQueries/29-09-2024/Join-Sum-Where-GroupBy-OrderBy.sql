--SELECT  CategoryName,[Description] FROM DBO.Categories

--Product tablosundaki t�m kay�tlar�n�n ID,Price,UnitsInStock,UnitPrice kolonlar�n� geri d�nd�r�n.

--SELECT
--p.ProductID as Id,
--p.ProductName as '�r�n Ad�',
--p.UnitsInStock as [Stok Adedi],
--p.UnitPrice as 'Birim Fiyat�'
--FROM Products p


-- EN Y�KSEK F�YATI BULALIM VE EN D���K

--SELECT  
--	MAX(p.UnitPrice) AS [Maksimum Fiyat],
--	min	(p.UnitPrice) AS [Minimum Fiyat],
--	avg	(p.UnitPrice) AS [Minimum Fiyat],
--	COUNT (*) AS [�r�n Say�s�],
--	SUM (p.UnitPrice*p.UnitsInStock) AS [Toplam De�er]
--FROM Products p

-- EN Y�KSEK F�YAT EN K���K F�YAT

--SELECT p.ProductName,p.UnitPrice FROM Products p
--order by UnitPrice desc

--TEMEL FONKSIYON

--SELECT 
--p.ProductName AS [DEFAULT],
--UPPER (p.ProductName) AS [B�Y�K HARF],
--LOWER (p.ProductName) AS [K���K HARF],
--LOWER (REPLACE(REPLACE(p.ProductName,' ','_'),'?','')) AS [URL]
--FROM Products p

--SELECT * FROM Products p
--WHERE UnitPrice >40

--SELECT * FROM Products p
--WHERE p.UnitPrice>=40 AND p.UnitPrice<=100

-- JOIN SQL'DE TABLOLARI �L��K�L� ALANLAR �ZER�NDEN B�RLE�T�RME
--JOIN TURLERI:
-- INNER JOIN B�RLE�T�R�LECEK �K� TABLODAK� E�LE�EN KAYILARI B�R ARAYA GET�R�R.
-- LEFT JOIN SOL TARAFTAK� TABLONUN T�M KAYILARIINI SA� TARAFTAK� TABLONUN E�LE�EN KAYITLARINI GET�R�R.
-- R�GHT JOIN SA� TARAFTAK� TABLONUN T�M KAYILARIINI SOL TARAFTAK� TABLONUN E�LE�EN KAYITLARINI GET�R�R.
-- OUTER FULL JOIN B�RLE�T�R�LECEK �K� TABLODAK� E�LE�EN VEYA E�LE�MEYEN Y�M KAYITLARI B�R ARAYA GET�R�R.


--SELECT p.*
--FROM Products p
--JOIN Categories c ON p.CategoryID = c.CategoryID
--WHERE p.UnitPrice BETWEEN 40 AND 100
--ORDER BY p.CategoryID;

--PRODUCTS VE CATEGORIES TABLOLARIN B�RLE�T�R�LMES�

--SELECT p.ProductID AS [ID],
--p.ProductName AS [�r�n],
--p.UnitPrice AS [Fiyat],
--c.CategoryName AS [Kategori]
--FROM Products p 
--JOIN Categories c ON p.CategoryID = c.CategoryID
--WHERE c.CategoryName= 'Beverages'

--YEN� B�R KATEGOR� EKLEYEL�M

--INSERT INTO Categories(CategoryName,[Description])
--VALUES ('Televizyon','Televizyon �r�nleri Burada')

--SELECT * FROM Categories c RIGHT JOIN Products p ON p.CategoryID = c.CategoryID

--�r�nler = ProductID,ProductName,UnitPrice Supplier = CompanyName

--SELECT p.ProductID [ID],
--	   P.ProductName [URUN],
--	   p.UnitPrice [FIYAT],
--	   s.CompanyName [TEDARIKCI]
--FROM Products p	
--JOIN  Suppliers s ON p.SupplierID = s.SupplierID
--ORDER BY [TEDARIKCI]

--�r�nler = ProductID,ProductName,UnitPrice CategoryName Ve Supplier CompanyName

--SELECT 
--	   p.ProductID [ID],
--	   P.ProductName [URUN],
--	   p.UnitPrice [FIYAT],
--	   s.CompanyName [TEDARIKCI],
--	   c.CategoryName [KATEGOR�]
--FROM Products p	
--JOIN  Suppliers s ON p.SupplierID = s.SupplierID RIGHT JOIN Categories C ON p.CategoryID = c.CategoryID
--ORDER BY [KATEGOR�],[TEDARIKCI]


--SELECT 
--	   p.ProductID [ID],
--	   P.ProductName [URUN],
--	   p.UnitPrice [FIYAT],
--	   s.CompanyName [TEDARIKCI]
--FROM Products p	
--JOIN  Suppliers s ON p.SupplierID = s.SupplierID
--ORDER BY [TEDARIKCI]

--HANG� S�PAR�� HANG� �ALI�AN TARAFINDAN HANG� M��TER�YE GER�EKLE�T�R�LM��T�R.
--ORDERID ORDERDATE EMPLOYEENAME CUSTOMERNAME

--SELECT 
--o.OrderID [Sipari� NO],
--o.OrderDate [Sipari� Tarihi],
--e.FirstName+' '+e.LastName [�al��an],
--c.CompanyName [M��teri]
--FROM Orders o
--JOIN Employees e ON o.EmployeeID = e.EmployeeID
--	JOIN Customers c ON c.CustomerID = o.CustomerID

--KATEGOR�YE G�RE �R�N STOK ADED�

--SELECT 
--c.CategoryName AS [Kategori],
--SUM(p.UnitsInStock) [Stok Miktar�]
--FROM Products p JOIN Categories c ON p.CategoryID = c.CategoryID
--GROUP BY c.CategoryName

--HANG� �LKEDE KA� M��TER�M�Z VAR

--SELECT
--c.Country [�lke],
--COUNT (*) [M��teri Say�s�]
--FROM Customers c
--GROUP BY C.Country
--ORDER BY [M��teri Say�s�] DESC

--EN �OK HANG� �LKEDE M��TER�M�Z VARSA M��TER� SAYISI �LE G�STEREL�M

--SELECT
--TOP (1)
--c.Country [�lke],
--COUNT (*) [M��teri Say�s�]
--FROM Customers c
--GROUP BY C.Country
--ORDER BY [M��teri Say�s�] DESC

--HANG� KATEGOR�DEN KA� �R�N VAR

--SELECT  
--c.CategoryName [Kategori],
--COUNT(ProductID) [ADET]

--FROM Products p RIGHT JOIN Categories c ON p.CategoryID = c.CategoryID
--GROUP BY c.CategoryName 

--HANG� �LKEYE NE KADARLIK KARGO HARCAMASI YAPMI�IZ

--SELECT 
--o.ShipCountry [�LKE],
--SUM (O.Freight) [KARGO HARCAMASI]
--FROM Orders o
--GROUP BY ShipCountry 
--ORDER BY [KARGO HARCAMASI] DESC 

--HANG� �LKEYE NE KADARLIK SATI� YAPMI�IZ

--SELECT 
--o.ShipCountry [�LKE],
--FORMAT(SUM(od.UnitPrice*od.Quantity*(1-od.Discount)), 'N2') [TUTAR]
--FROM Orders o JOIN OrderDetails od ON o.OrderID = od.OrderID
--GROUP BY ShipCountry 

--TUTAR KOLONUNDA G�R�NEN SAYININ 18.810,05 �EKL�NDE G�R�NMES� ()

--GERMANY DEN TEDAR�K ETT���M�Z �R�NLER�N TOPLAM SATI� TUTARINI BULUNUZ.

--SELECT 
--c.CategoryName [Kategori],
--SUM(od.UnitPrice*od.Quantity*(1-od.Discount)) [TUTAR]
--FROM OrderDetails od JOIN Products p ON od.ProductID = P.ProductID
--JOIN Suppliers S ON P.SupplierID = s.SupplierID
--JOIN Categories c ON p.CategoryID = c.CategoryID
--WHERE S.Country='Germany'
--GROUP BY C.CategoryName
--HAVING SUM(od.UnitPrice*od.Quantity*(1-od.Discount))>20000
--ORDER BY [TUTAR] DESC

--B�LGELERE G�RE SATI� TUTARI

--SELECT r.RegionDescription AS [B�LGE],
--FORMAT(SUM(od.UnitPrice*od.Quantity*(1-od.Discount)),'N2') AS [TUTAR]
--FROM OrderDetails od JOIN Orders o ON od.OrderID = o.OrderID --d
--JOIN Employees e ON o.EmployeeID = e.EmployeeID--d
--JOIN EmployeeTerritories et ON e.EmployeeID = et.EmployeeID--d
--JOIN Territories t ON et.TerritoryID = t.TerritoryID--d
--JOIN Region r ON t.RegionID = r.RegionID--d

--GROUP BY r.RegionDescription

--HANG� �ALI�AN HANG� KATEGOR�DEN NE KADAR SATI� YAPMI�

--SELECT
--cu.CompanyName [M��teri],
--c.CategoryName AS [Kategori],
--FORMAT(SUM(od.UnitPrice*od.Quantity*(1-od.Discount)),'N2') AS [TUTAR]
--FROM OrderDetails od
--JOIN Orders o ON od.OrderID = O.OrderID
--JOIN Customers cu ON cu.CustomerID = o.CustomerID
--JOIN Products p ON od.ProductID = p.ProductID
--JOIN Categories c ON p.CategoryID =c.CategoryID

--GROUP BY c.CategoryName , cu.CompanyName
--ORDER BY cu.CompanyName , c.CategoryName 

--1997 MART �ATI�LARI

SELECT * FROM Orders o
JOIN OrderDetails od ON o.OrderID=od.OrderID
JOIN Products p ON od.ProductID = P.ProductID
WHERE o.OrderDate BETWEEN '1997-03-01' AND '1997-03-31' AND ProductName = 'Chai'





							

