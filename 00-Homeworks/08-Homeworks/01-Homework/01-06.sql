SELECT Categories.CategoryName, COUNT(Products.ProductID) AS ProductCount
FROM Products
JOIN Categories ON Products.CategoryID = Categories.CategoryID
GROUP BY Categories.CategoryName;
