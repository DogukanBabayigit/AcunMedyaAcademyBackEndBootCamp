SELECT YEAR(OrderDate) AS OrderYear, 
MONTH(OrderDate) AS OrderMonth, 
SUM([OrderDetails].UnitPrice * [OrderDetails].Quantity * (1 - [OrderDetails].Discount)) 
AS MonthlySales
FROM Orders
JOIN [OrderDetails] ON Orders.OrderID = [OrderDetails].OrderID
GROUP BY YEAR(OrderDate), MONTH(OrderDate)
ORDER BY OrderYear, OrderMonth;
