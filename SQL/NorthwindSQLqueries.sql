--SELECT * FROM Employees
--WHERE City = 'London';

--SELECT * FROM Employees
--WHERE TitleOfCourtesy = 'Dr.';

--SELECT CompanyName, City, Country, Region
--FROM Customers WHERE Region='BC';

--SELECT Country, ContactName
--FROM Customers
--ORDER BY Country, ContactName ASC

--SELECT TOP 100 CompanyName, City FROM Customers
--WHERE Country = 'France';

--SELECT ProductName, UnitPrice FROM Products
--WHERE CategoryID=1 AND Discontinued= 0

--select ProductName, UnitPrice FROM Products
--WHERE UnitsInStock > 0 AND UnitPrice > 29.99;

--SELECT DISTINCT Country FROM Customers
--WHERE ContactTitle = 'Owner';

--SELECT CompanyName, ContactName, Phone 
--INTO French_customers
--FROM Customers
--WHERE Country = 'France';

--SELECT ProductName
--FROM Products WHERE ProductName LIKE 'Ch%';

--SELECT ProductName
--FROM Products WHERE ProductName LIKE '[AEIOU]%';

--SELECT * FROM Customers
--WHERE Region LIKE '_A';

--SELECT * FROM Customers WHERE Region IN ('WA','SP');

--select * from customers
--where region= 'WA' OR region='SP';

--SELECT * FROM EmployeeTerritories
--WHERE TerritoryID BETWEEN 06800 AND 09999;

--SELECT ProductID, ProductName FROM Products
--WHERE UnitPrice < 5.00;

--SELECT CategoryName FROM Categories
--WHERE CategoryName LIKE '[BS]%';

--SELECT COUNT(*) AS "Number Of Orders"
--FROM Orders
--WHERE EmployeeID IN (5,7);

--SELECT CategoryName FROM Categories
--WHERE CategoryName LIKE '[A-P]%';

--SELECT CompanyName AS "Company Name",
--City + ', this is a space ' + Country AS "City"
--FROM Customers;

--SELECT 
--FirstName + ' ' + LastName AS "Employee Name",
--HomePhone AS "Contact Number"
--FROM Employees;

--SELECT CompanyName AS 'Company Name', 
--City + ', ' + Country AS City
--FROM Customers WHERE Region IS NULL;

--SELECT DISTINCT Country FROM Customers
--WHERE Region IS NOT NULL;

--SELECT UnitPrice, Quantity, Discount,
--UnitPrice * Quantity AS 'Gross Total'
--FROM [Order Details]
--ORDER BY 'Gross Total' DESC;

--SELECT top 2 UnitPrice, Quantity, Discount,
--UnitPrice * Quantity AS 'Gross Total'
--FROM [Order Details]
--ORDER BY 'Gross Total' DESC;

--SELECT SUBSTRING('alex', 2, 2);

--SELECT CHARINDEX('y', 'harry');

--SELECT LEFT('Chen', 3); aLso works for right

--SELECT LTRIM('   f'); doesnt work when its multiple words 

--SELECT REPLACE('Nish', 'i', 'a'); - replaces 2nd argument with third

--SELECT UPPER('leo'); - makes it capitalised
--SELECT LOWER('LEO'); - lowercase

--SELECT LEN('Sparta'); - returns count of characters

--SELECT ProductName
--FROM Products
--WHERE CHARINDEX('''', ProductName) != 0;

--SELECT DATEADD(dd, 5, GETDATE());

--SELECT DATEDIFF(dd, '2020-05-05', '2020-05-06');

--SELECT FirstName + ' ' + LastName AS 'Employee Name',
--DATEDIFF(dd, BirthDate, GETDATE()) / 365.25 AS 'Age'
--FROM Employees; - gets the employee name and calculates age

--USING SELECT CASE
--CASE statements can be useful when you need varying results outputs
--based on different data
--use single quotes for data and double quotes for coloumn

--SELECT 
--CASE
--WHEN DATEDIFF(dd, OrderDate, ShippedDate) < 10 THEN 'On Time'
--ELSE 'Overdue'
--END AS 'Status'
--From Orders;

-- if else, when true do this, if false do this instead

--SELECT 
--CASE 
--WHEN DATEDIFF(dd, BirthDate, GETDATE()) / 365.25 > 65 THEN 'Retired'
--WHEN DATEDIFF(dd, BirthDate, GETDATE()) / 365.25  > 60 THEN 'Almost retired'
--ELSE 'More than 5 years to go'
--END AS "Retirement Status"
--FROM Employees;





