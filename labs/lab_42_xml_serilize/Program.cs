using lab_42_xml_serilize.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace lab_42_xml_serilize
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            //read some northwind products
            using(var db = new NorthwindContext())
            {
                products = db.Products.Take(5).ToList();
            }
            products.ForEach(p => Console.WriteLine($"{p.ProductId} {p.ProductName}"));


            var xmlProducts = new XElement(
                "Products",
                from p in products
                select new XElement("Product",
                    new XElement("ProductID", p.ProductId),
                    new XElement("ProductName", p.ProductName),
                    new XElement("UnitPrice", p.UnitPrice)
                    )
                );

            //save document
            var xmlProductDoc = new XDocument(xmlProducts);
            xmlProductDoc.Save("Products.xml");

            //print
            Console.WriteLine(xmlProductDoc);

            //assume data being sent to us over the internet
            //safest to stream
            var xmlProducts2 = new Products();

            using(var reader = new StreamReader("Products.xml"))
            {
                //deserilize from xml into northwind products
                var serializer = new XmlSerializer(typeof(Products));
                xmlProducts2 = (Products)serializer.Deserialize(reader);
            };
        }
    }

    [XmlRoot("Products")]
    public class Products
    {
        [XmlElement("Product")]
        public List<Product> XMLProductsFromBrazil { get; set; }
    }
}
