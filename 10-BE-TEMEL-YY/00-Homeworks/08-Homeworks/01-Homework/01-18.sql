SELECT Customers.CustomerID, Customers.CompanyName, COUNT(Orders.OrderID) AS OrderCount
FROM Orders
JOIN Customers ON Orders.CustomerID = Customers.CustomerID
GROUP BY Customers.CustomerID, Customers.CompanyName
HAVING COUNT(Orders.OrderID) >= 5;
