using System;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;

namespace EFNorthWindApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindContext())
            {
                //var orderQuery =
                //  from order in db.Orders
                //  where order.Freight > 750
                //  select order;

                //foreach (var order in orderQuery)
                //{
                //    Console.WriteLine($"{order.CustomerId} paid {order.Freight} for shipping to {order.ShipCity}");
                //}

                //var orderQueryWithCust =
                //    from order in db.Orders.Include(o => o.Customer) //this will join and retrieve all customer and columns
                //    where order.Freight > 750
                //    select order;

                //foreach(var order in orderQueryWithCust)
                //{
                //    if(order.Customer != null)
                //    {
                //        Console.WriteLine($"{order.Customer.ContactName} of {order.Customer.City} paid {order.Freight} for shipping");
                //    }
                //}

                //var orderQueryUsingInnerJoin = //we can specify what exactly we want
                //  from order in db.Orders
                //  where order.Freight > 750
                //  join customer in db.Customers on order.CustomerId equals customer.CustomerId
                //  select new { CustomerContactName = customer.ContactName, City = customer.City, Freight = order.Freight };

                //foreach (var result in orderQueryUsingInnerJoin)
                //{
                //    Console.WriteLine($" {result.CustomerContactName} of {result.City} paid {result.Freight} for shipping");
                //}


                //SQL QUERY PROJECT QUERIES

                //1.1
                var query1 =
                     db.Customers.Where(c => c.City == "London" || c.City == "Paris");
  
                Console.WriteLine("Query 1.1");
                foreach(var cust in query1)
                {
                    Console.WriteLine($"{cust.CustomerId} - {cust.CompanyName} - {cust.Address} - {cust.City} - {cust.PostalCode} - {cust.Country}");
                }

                //1.2
                var query2 =
                    db.Products.Where(c => c.QuantityPerUnit.Contains("bottle"));

                Console.WriteLine("Query 1.2");
                foreach(var product in query2)
                {
                    Console.WriteLine($"{product.ProductName} - {product.QuantityPerUnit}");
                }

                //1.3
                var query3 =
                    from product in db.Products
                    where product.QuantityPerUnit.Contains("bottle")
                    join supplier in db.Suppliers on product.SupplierId equals supplier.SupplierId
                    select new
                    {
                        ProductName = product.ProductName,
                        QuantityPerUnit = product.QuantityPerUnit,
                        CompanyName = supplier.CompanyName,
                        Country = supplier.Country
                    };

                Console.WriteLine("Query 3");
                foreach(var result in query3)
                {
                    Console.WriteLine($"{result.ProductName} - {result.QuantityPerUnit} - {result.CompanyName} - {result.Country}");
                }

                //1.4
                //var query4 =
                //    from product in db.Products         
                //    join category in db.Categories on product.CategoryId equals category.CategoryId
                //    group category by category.CategoryName into productCategory
                //    select new
                //    {
                //        CategoryName = productCategory.Key,
                //        NoOfProducts = productCategory.Count()
                //    };

                //Console.WriteLine("Query 4");
                //foreach(var result in query4)
                //{
                //    Console.WriteLine($"{result.CategoryName} - {result.NoOfProducts}");
                //}

                var query4 =
                     db.Products.Include(p => p.Category)
                    .GroupBy(p => p.Category.CategoryName)
                    .OrderBy(item => item.Key)
                    .Select(item => Tuple.Create(item.Key, item.Count()));

                Console.WriteLine("Query 4");

                foreach(var result in query4)
                {
                    Console.WriteLine($"{result.Item1} - {result.Item2}");
                }    

                //1.5
                var query5 =
                    db.Employees.Where(c => c.Country == "UK");

                Console.WriteLine("Query 5");
                foreach(var person in query5)
                {
                    Console.WriteLine($"{person.TitleOfCourtesy} {person.FirstName} {person.LastName} {person.City}");
                }

                //1.6
                var query6 =
                    from order in db.Orders
                    join orderDetail in db.OrderDetails on order.OrderId equals orderDetail.OrderId
                    join employeeTerritory in db.EmployeeTerritories on order.EmployeeId equals employeeTerritory.EmployeeId
                    join territory in db.Territories on employeeTerritory.TerritoryId equals territory.TerritoryId
                    join region in db.Region on territory.RegionId equals region.RegionId
                    group orderDetail by region.RegionDescription into regionGroup
                    where regionGroup.Sum(s => s.UnitPrice * s.Quantity * ((decimal)s.Discount) ) > 100000
                     
                    select new
                    {
                        Region = regionGroup.Key,
                        TotalSales = regionGroup.Sum(s => s.UnitPrice * (s.Quantity * (decimal)s.Discount))
                       
                    };

                Console.WriteLine("Query 6");
                foreach(var result in query6)
                {
                    Console.WriteLine($"{result.Region.Trim()} - {result.TotalSales}");
                }

                //1.7
                var query7 =
                    db.Orders.Where(o => o.Freight > 100 && (o.ShipCountry == "USA" || o.ShipCountry == "UK")).Count();

                Console.WriteLine("Query 7");
                Console.WriteLine(query7);

            }
        }
    }
}
