-- SQL TEST

--EXCERISE 1
--1.1
--Write a query that lists all Customers in either Paris or London, include CustomerID, CompanyName and all address fields
SELECT CustomerID, CompanyName, 
Address + ',' + City + ', ' + PostalCode + ', ' + Country AS "Address"
FROM Customers
WHERE City = 'Paris' OR City = 'London';
--1.2
--List all products stored in bottles
SELECT ProductName, QuantityPerUnit FROM Products
WHERE QuantityPerUnit LIKE '%bottle%';
--1.3
--Repeat question above, but add in the SupplierName and Country
SELECT p.ProductName, p.QuantityPerUnit, s.CompanyName, s.Country FROM Suppliers s
INNER JOIN  Products p ON s.SupplierID = p.SupplierID
WHERE p.QuantityPerUnit LIKE '%bottle%';
--1.4
--Write an SQL Statement that shows how many products that are in each category, include CategoryName in
--result set and list the highest number first
SELECT c.CategoryName, COUNT(*) AS "Products in Category"
FROM Products p 
INNER JOIN Categories c ON p.CategoryID = c.CategoryID
GROUP BY c.CategoryName
ORDER BY c.CategoryName DESC
--1.5
--List all UK employees using concatenation to join their title of courtesy, first name and last name together.
--Also include their city of residence
SELECT FirstName + ' ' + LastName AS "Employee Name",
City
FROM Employees
WHERE Country = 'UK';
--1.6
--List Sales Totals for all Sales Regions with a Sales total greather than 1mil. Use rounding or FORMAT to
--present the numbers
SELECT FORMAT(SUM(od.Quantity * od.UnitPrice), 'C')  AS "SALES", r.RegionDescription
FROM [Order Details] od
INNER JOIN Orders o ON o.OrderID = od.OrderID
INNER JOIN EmployeeTerritories et ON o.EmployeeID = et.EmployeeID
INNER JOIN Territories t ON et.TerritoryID = t.TerritoryID
INNER JOIN Region r ON r.RegionID = t.RegionID
GROUP BY r.RegionDescription
HAVING SUM(od.Quantity * od.UnitPrice) > 1000000
ORDER BY "SALES" ASC
--1.7
--Count how many Orders have a Freight amount greater than 100.00 and either USA or UK as Ship Country.
SELECT COUNT(*) FROM Orders AS "No. Of Orders"
WHERE Freight > 100 AND (ShipCountry = 'USA' OR ShipCountry ='UK')
--1.8
--Write an SQL statement to identify the Order Number of the Order with the highest amount of discount applied
--to that order
SELECT TOP 1 od.OrderID,
SUM(od.UnitPrice * od.Quantity * od.Discount) AS "Discount Amount"
FROM [Order Details] od
GROUP BY od.OrderID
ORDER BY SUM(od.UnitPrice * od.Quantity * od.Discount) DESC

--EXERCISE 2
--2.1
--Write the correct SQL statement to create the following table 
CREATE TABLE Spartans
(
	SpartanID INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	SpartanTitle VARCHAR(30),
	FirstName VARCHAR(30),
	LastName VARCHAR(30),
	University VARCHAR(50),
	Course VARCHAR(30),
	Mark DECIMAL
);
--2.2
--Insert the correct values into the table
INSERT INTO Spartans
(
	SpartanID,
	SpartanTitle,
	FirstName,
	LastName,
	University,
	Course,
	Mark
)
VALUES
(
	1,
	'Trainee',
	'Bruno',
	'Silva',
	'Royal Holloway',
	'Drama & Theatre',
	2.1
);

--Exercise 3

--3.1
--List all Employees from the Employees table and who they report to. use self join
SELECT e.FirstName + ' ' + e.LastName AS "Employee Name",
b.FirstName + ' ' + b.LastName AS "Reports To"
FROM Employees e
LEFT JOIN Employees b ON e.ReportsTo = b.EmployeeID
ORDER BY "Reports To", "Employee Name"
--3.2
--List all suppliers with total sales over 10k in the order Details table. Include the Company Name from
--the Suppliers Table
SELECT SUM(od.UnitPrice * od.Quantity*(1-od.Discount)) AS "Total Sales", s.CompanyName
FROM [Order Details] od
INNER JOIN Products p ON od.ProductID = p.ProductID
INNER JOIN Suppliers s ON p.SupplierID = s.SupplierID
GROUP BY s.CompanyName
HAVING SUM(od.UnitPrice * od.Quantity*(1-od.Discount))  > 10000
ORDER BY SUM(od.UnitPrice * od.Quantity*(1-od.Discount)) DESC
--3.3
--List the top 10 Customers YTD for the latest year in the Orders file. Based on total value of orders shipped.
SELECT TOP 10 c.CustomerID AS "Customer ID", c.CompanyName AS "Company",
FORMAT(SUM(UnitPrice * Quantity * (1-Discount)), 'C') AS "YTD"
FROM Customers c 
INNER JOIN Orders o ON o.CustomerID= c.CustomerID
INNER JOIN [Order Details] od ON od.OrderID= o.OrderID 
WHERE YEAR(OrderDate)=(SELECT MAX(YEAR(OrderDate)) FROM Orders)
AND o.ShippedDate IS NOT NULL
GROUP BY c.CustomerID, c.CompanyName
ORDER BY SUM(UnitPrice * Quantity * (1-Discount)) DESC;
--3.4
--Plot the Average Ship Time by month for all data in the Orders Table
SELECT MONTH(OrderDate) Month, YEAR(OrderDate) Year, 
AVG(CAST(DATEDIFF(d, OrderDate, ShippedDate) AS DECIMAL(10,2))) AS "ShipTime"
FROM Orders
WHERE ShippedDate IS NOT NULL
GROUP BY YEAR(OrderDate), MONTH(OrderDate)
ORDER BY Year ASC, Month ASC



SELECT OrderDate, ShippedDate,
DATEDIFF(dd, OrderDate, ShippedDate) AS "Shipping Time"
FROM Orders

SELECT p.SupplierID AS "SupplierID", CompanyName AS "Company Name", 
AVG(p.UnitsOnOrder)  "Average On Order"
FROM Products p 
INNER JOIN Suppliers s ON p.SupplierID = s.SupplierID
GROUP BY p.SupplierID, CompanyName
ORDER BY "Average On Order" desc

--Subqueires
SELECT OrderID, ProductID, UnitPrice, Quantity, Discount, 
(SELECT AVG(UnitPrice) FROM [Order Details] od) AS "Avg Price"
FROM [Order Details]

SELECT * FROM [Order Details] od 
INNER JOIN 
(SELECT ProductID, SUM(UnitPrice *Quantity) AS "Total"
FROM [Order Details] GROUP BY ProductID)
sq1 ON sq1.ProductID = od.ProductID

SELECT EmployeeID AS "Employee/Supplier"
FROM Employees
UNION
SELECT SupplierID
FROM Suppliers

SELECT SupplierID,
SUM(UnitsOnOrder) AS "Total On Order",
AVG(UnitsOnOrder) AS "Avg On Order"
FROM Products
GROUP BY SupplierID
HAVING AVG(UnitsOnOrder) > 5

SELECT c.CompanyName
FROM Customers c
LEFT JOIN Orders o ON c.CustomerID = o.CustomerID

