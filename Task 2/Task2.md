1. Open SQL Server Management Studio (or an equivalent SQL Management Software)
2. Connect to Northwind DB (Same DB as you used in Geek Week)
3. Write a query that shows each employee’s first name and the number of orders they have placed. Group the results by employee’s first name.

Please add your SQL query below AND add explanation of the query: 

```
[Insert Code Here]
SELECT e.FirstName, COUNT(od.Quantity) AS AmountOfOrders
FROM Employees e
JOIN Orders o ON e.EmployeeID = o.EmployeeID
JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY e.FirstName;
[Insert Explanation Here]
So it selects from the employee table and selects the first name column, names the quantity as the amounts of orders, then it takes the employee id to join it to orders to get order details merged to employees

4. For submission commit and push this .md file to Github
