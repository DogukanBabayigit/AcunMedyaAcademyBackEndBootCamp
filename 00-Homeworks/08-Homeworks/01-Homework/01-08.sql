SELECT Country, COUNT(CustomerID) AS CustomerCount
FROM Customers
GROUP BY Country
ORDER BY CustomerCount DESC;
