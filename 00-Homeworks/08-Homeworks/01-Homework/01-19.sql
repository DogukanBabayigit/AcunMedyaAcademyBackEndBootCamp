SELECT Customers.Country, 
SUM([OrderDetails].UnitPrice * [OrderDetails].Quantity * (1 - [OrderDetails].Discount)) 
AS TotalSales
FROM Orders
JOIN Customers ON Orders.CustomerID = Customers.CustomerID
JOIN [OrderDetails] ON Orders.OrderID = [OrderDetails].OrderID
GROUP BY Customers.Country;
