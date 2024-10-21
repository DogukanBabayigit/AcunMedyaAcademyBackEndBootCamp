--SELECT  CategoryName,[Description] FROM DBO.Categories

--Product tablosundaki tüm kayýtlarýnýn ID,Price,UnitsInStock,UnitPrice kolonlarýný geri döndürün.

--SELECT
--p.ProductID as Id,
--p.ProductName as 'Ürün Adý',
--p.UnitsInStock as [Stok Adedi],
--p.UnitPrice as 'Birim Fiyatý'
--FROM Products p


-- EN YÜKSEK FÝYATI BULALIM VE EN DÜÞÜK

--SELECT  
--	MAX(p.UnitPrice) AS [Maksimum Fiyat],
--	min	(p.UnitPrice) AS [Minimum Fiyat],
--	avg	(p.UnitPrice) AS [Minimum Fiyat],
--	COUNT (*) AS [Ürün Sayýsý],
--	SUM (p.UnitPrice*p.UnitsInStock) AS [Toplam Deðer]
--FROM Products p

-- EN YÜKSEK FÝYAT EN KÜÇÜK FÝYAT

--SELECT p.ProductName,p.UnitPrice FROM Products p
--order by UnitPrice desc

--TEMEL FONKSIYON

--SELECT 
--p.ProductName AS [DEFAULT],
--UPPER (p.ProductName) AS [BÜYÜK HARF],
--LOWER (p.ProductName) AS [KÜÇÜK HARF],
--LOWER (REPLACE(REPLACE(p.ProductName,' ','_'),'?','')) AS [URL]
--FROM Products p

--SELECT * FROM Products p
--WHERE UnitPrice >40

--SELECT * FROM Products p
--WHERE p.UnitPrice>=40 AND p.UnitPrice<=100

-- JOIN SQL'DE TABLOLARI ÝLÝÞKÝLÝ ALANLAR ÜZERÝNDEN BÝRLEÞTÝRME
--JOIN TURLERI:
-- INNER JOIN BÝRLEÞTÝRÝLECEK ÝKÝ TABLODAKÝ EÞLEÞEN KAYILARI BÝR ARAYA GETÝRÝR.
-- LEFT JOIN SOL TARAFTAKÝ TABLONUN TÜM KAYILARIINI SAÐ TARAFTAKÝ TABLONUN EÞLEÞEN KAYITLARINI GETÝRÝR.
-- RÝGHT JOIN SAÐ TARAFTAKÝ TABLONUN TÜM KAYILARIINI SOL TARAFTAKÝ TABLONUN EÞLEÞEN KAYITLARINI GETÝRÝR.
-- OUTER FULL JOIN BÝRLEÞTÝRÝLECEK ÝKÝ TABLODAKÝ EÞLEÞEN VEYA EÞLEÞMEYEN YÜM KAYITLARI BÝR ARAYA GETÝRÝR.


--SELECT p.*
--FROM Products p
--JOIN Categories c ON p.CategoryID = c.CategoryID
--WHERE p.UnitPrice BETWEEN 40 AND 100
--ORDER BY p.CategoryID;

--PRODUCTS VE CATEGORIES TABLOLARIN BÝRLEÞTÝRÝLMESÝ

--SELECT p.ProductID AS [ID],
--p.ProductName AS [Ürün],
--p.UnitPrice AS [Fiyat],
--c.CategoryName AS [Kategori]
--FROM Products p 
--JOIN Categories c ON p.CategoryID = c.CategoryID
--WHERE c.CategoryName= 'Beverages'

--YENÝ BÝR KATEGORÝ EKLEYELÝM

--INSERT INTO Categories(CategoryName,[Description])
--VALUES ('Televizyon','Televizyon Ürünleri Burada')

--SELECT * FROM Categories c RIGHT JOIN Products p ON p.CategoryID = c.CategoryID

--Ürünler = ProductID,ProductName,UnitPrice Supplier = CompanyName

--SELECT p.ProductID [ID],
--	   P.ProductName [URUN],
--	   p.UnitPrice [FIYAT],
--	   s.CompanyName [TEDARIKCI]
--FROM Products p	
--JOIN  Suppliers s ON p.SupplierID = s.SupplierID
--ORDER BY [TEDARIKCI]

--Ürünler = ProductID,ProductName,UnitPrice CategoryName Ve Supplier CompanyName

--SELECT 
--	   p.ProductID [ID],
--	   P.ProductName [URUN],
--	   p.UnitPrice [FIYAT],
--	   s.CompanyName [TEDARIKCI],
--	   c.CategoryName [KATEGORÝ]
--FROM Products p	
--JOIN  Suppliers s ON p.SupplierID = s.SupplierID RIGHT JOIN Categories C ON p.CategoryID = c.CategoryID
--ORDER BY [KATEGORÝ],[TEDARIKCI]


--SELECT 
--	   p.ProductID [ID],
--	   P.ProductName [URUN],
--	   p.UnitPrice [FIYAT],
--	   s.CompanyName [TEDARIKCI]
--FROM Products p	
--JOIN  Suppliers s ON p.SupplierID = s.SupplierID
--ORDER BY [TEDARIKCI]

--HANGÝ SÝPARÝÞ HANGÝ ÇALIÞAN TARAFINDAN HANGÝ MÜÞTERÝYE GERÇEKLEÞTÝRÝLMÝÞTÝR.
--ORDERID ORDERDATE EMPLOYEENAME CUSTOMERNAME

--SELECT 
--o.OrderID [Sipariþ NO],
--o.OrderDate [Sipariþ Tarihi],
--e.FirstName+' '+e.LastName [Çalýþan],
--c.CompanyName [Müþteri]
--FROM Orders o
--JOIN Employees e ON o.EmployeeID = e.EmployeeID
--	JOIN Customers c ON c.CustomerID = o.CustomerID

--KATEGORÝYE GÖRE ÜRÜN STOK ADEDÝ

--SELECT 
--c.CategoryName AS [Kategori],
--SUM(p.UnitsInStock) [Stok Miktarý]
--FROM Products p JOIN Categories c ON p.CategoryID = c.CategoryID
--GROUP BY c.CategoryName

--HANGÝ ÜLKEDE KAÇ MÜÞTERÝMÝZ VAR

--SELECT
--c.Country [Ülke],
--COUNT (*) [Müþteri Sayýsý]
--FROM Customers c
--GROUP BY C.Country
--ORDER BY [Müþteri Sayýsý] DESC

--EN ÇOK HANGÝ ÜLKEDE MÜÞTERÝMÝZ VARSA MÜÞTERÝ SAYISI ÝLE GÖSTERELÝM

--SELECT
--TOP (1)
--c.Country [Ülke],
--COUNT (*) [Müþteri Sayýsý]
--FROM Customers c
--GROUP BY C.Country
--ORDER BY [Müþteri Sayýsý] DESC

--HANGÝ KATEGORÝDEN KAÇ ÜRÜN VAR

--SELECT  
--c.CategoryName [Kategori],
--COUNT(ProductID) [ADET]

--FROM Products p RIGHT JOIN Categories c ON p.CategoryID = c.CategoryID
--GROUP BY c.CategoryName 

--HANGÝ ÜLKEYE NE KADARLIK KARGO HARCAMASI YAPMIÞIZ

--SELECT 
--o.ShipCountry [ÜLKE],
--SUM (O.Freight) [KARGO HARCAMASI]
--FROM Orders o
--GROUP BY ShipCountry 
--ORDER BY [KARGO HARCAMASI] DESC 

--HANGÝ ÜLKEYE NE KADARLIK SATIÞ YAPMIÞIZ

--SELECT 
--o.ShipCountry [ÜLKE],
--FORMAT(SUM(od.UnitPrice*od.Quantity*(1-od.Discount)), 'N2') [TUTAR]
--FROM Orders o JOIN OrderDetails od ON o.OrderID = od.OrderID
--GROUP BY ShipCountry 

--TUTAR KOLONUNDA GÖRÜNEN SAYININ 18.810,05 ÞEKLÝNDE GÖRÜNMESÝ ()

--GERMANY DEN TEDARÝK ETTÝÐÝMÝZ ÜRÜNLERÝN TOPLAM SATIÞ TUTARINI BULUNUZ.

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

--BÖLGELERE GÖRE SATIÞ TUTARI

--SELECT r.RegionDescription AS [BÖLGE],
--FORMAT(SUM(od.UnitPrice*od.Quantity*(1-od.Discount)),'N2') AS [TUTAR]
--FROM OrderDetails od JOIN Orders o ON od.OrderID = o.OrderID --d
--JOIN Employees e ON o.EmployeeID = e.EmployeeID--d
--JOIN EmployeeTerritories et ON e.EmployeeID = et.EmployeeID--d
--JOIN Territories t ON et.TerritoryID = t.TerritoryID--d
--JOIN Region r ON t.RegionID = r.RegionID--d

--GROUP BY r.RegionDescription

--HANGÝ ÇALIÞAN HANGÝ KATEGORÝDEN NE KADAR SATIÞ YAPMIÞ

--SELECT
--cu.CompanyName [Müþteri],
--c.CategoryName AS [Kategori],
--FORMAT(SUM(od.UnitPrice*od.Quantity*(1-od.Discount)),'N2') AS [TUTAR]
--FROM OrderDetails od
--JOIN Orders o ON od.OrderID = O.OrderID
--JOIN Customers cu ON cu.CustomerID = o.CustomerID
--JOIN Products p ON od.ProductID = p.ProductID
--JOIN Categories c ON p.CategoryID =c.CategoryID

--GROUP BY c.CategoryName , cu.CompanyName
--ORDER BY cu.CompanyName , c.CategoryName 

--1997 MART ÞATIÞLARI

SELECT * FROM Orders o
JOIN OrderDetails od ON o.OrderID=od.OrderID
JOIN Products p ON od.ProductID = P.ProductID
WHERE o.OrderDate BETWEEN '1997-03-01' AND '1997-03-31' AND ProductName = 'Chai'





							

