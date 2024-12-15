SELECT Shippers.CompanyName, COUNT(Orders.OrderID) AS OrderCount
FROM Orders
JOIN Shippers ON Orders.ShipVia = Shippers.ShipperID
GROUP BY Shippers.CompanyName;
