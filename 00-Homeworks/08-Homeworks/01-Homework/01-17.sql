SELECT Categories.CategoryName, 
AVG(Products.UnitPrice) 
AS AveragePrice
FROM Products
JOIN Categories 
ON Products.CategoryID = Categories.CategoryID
GROUP BY Categories.CategoryName;
