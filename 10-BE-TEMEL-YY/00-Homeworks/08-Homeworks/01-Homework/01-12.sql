SELECT OrderID, SUM(UnitPrice * Quantity * (1 - Discount)) AS TotalAmount
FROM [OrderDetails]
GROUP BY OrderID;
