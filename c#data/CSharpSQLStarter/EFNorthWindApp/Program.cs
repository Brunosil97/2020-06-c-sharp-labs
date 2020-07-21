using System;
using System.Linq;
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
                //from customer in db.Customers
                //where customer.City == "London" || customer.City == "Paris"
                //select customer;

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
                var query4 =
                    from product in db.Products
              
                    join category in db.Categories on product.CategoryId equals category.CategoryId
                    group category by category.CategoryName into productCategory
                    select new
                    {
                        CategoryName = productCategory.Key,
                        NoOfProducts = productCategory.Count()
                    };

                Console.WriteLine("Query 4");
                foreach(var result in query4)
                {
                    Console.WriteLine($"{result.CategoryName} - {result.NoOfProducts}");
                }

                //1.5
                var query5 =
                    db.Employees.Where(c => c.Country == "UK");

                Console.WriteLine("Query 5");
                foreach(var person in query5)
                {
                    Console.WriteLine($"{person.TitleOfCourtesy} {person.FirstName} {person.LastName} {person.City}");
                }

            }
        }
    }
}
