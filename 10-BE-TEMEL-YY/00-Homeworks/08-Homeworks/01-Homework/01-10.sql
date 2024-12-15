SELECT Employees.EmployeeID, CONCAT(Employees.FirstName, ' ', Employees.LastName) AS EmployeeName, COUNT(Orders.OrderID) AS OrderCount
FROM Orders
JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID
GROUP BY Employees.EmployeeID, Employees.FirstName, Employees.LastName;
