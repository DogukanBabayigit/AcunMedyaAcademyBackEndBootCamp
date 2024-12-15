SELECT Employees.EmployeeID, 
CONCAT(Employees.FirstName, ' ', Employees.LastName) 
AS EmployeeName, 
SUM([OrderDetails].UnitPrice * [OrderDetails].Quantity * (1 - [OrderDetails].Discount)) 
AS TotalSales
FROM Orders
JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID
JOIN [OrderDetails] ON Orders.OrderID = [OrderDetails].OrderID
GROUP BY Employees.EmployeeID, Employees.FirstName, Employees.LastName;
