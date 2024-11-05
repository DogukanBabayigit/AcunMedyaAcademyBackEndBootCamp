SELECT Products.ProductName, SUM([OrderDetails].Quantity) AS TotalQuantity
FROM [OrderDetails]
JOIN Products ON [OrderDetails].ProductID = Products.ProductID
GROUP BY Products.ProductName
ORDER BY TotalQuantity DESC

