using Newtonsoft.Json;
using northwind_api_client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading;

namespace northwind_api_client
{
    class Program
    {
        static List<Customer> customers = new List<Customer>();
        static Customer customer = new Customer();

        static Uri customerUrl = new Uri("https://localhost:44361/api/Customers");
        static void Main(string[] args)
        {
            //async get all Customers
            Thread.Sleep(7000);

            //async get one Customer

            GetOneCustomer("ALFKI");

            Thread.Sleep(2000);

            Console.WriteLine($"I got the fist customer, Name: {customer.ContactName}");

            //Post a customer
            //var newCustomer = new Customer()
            //{
            //    CustomerId = "NEW04",
            //    ContactName = "Bruno",
            //    CompanyName = "My Comapny",
            //    City = "London",
            //    Country = "UK",

            //};
            GetAllCustomers();
            Thread.Sleep(2000);

            //PostCustomerAsync(newCustomer);
            Thread.Sleep(2000);

            Console.WriteLine($"customer list count is {customers.Count}");

            //update


            //delete
            DeleteCustomer("NEW02");
        }

        static void DeleteCustomer(string customerId)
        {
            if (GetCustomer(customerId))
            {
                using (var httpClient = new HttpClient())
                {
                    var data = httpClient.DeleteAsync(customerUrl + $"/{customerId}");
                    Console.WriteLine($"Delete was successful: {data.Result.IsSuccessStatusCode}");
                }
            }
            else
            {
                Console.WriteLine($"Customer {customerId} does not exist");
            }
        }
        static async void PostCustomerAsync(Customer newCustomer)
        {
            //check if does not exist
           if (GetCustomer(newCustomer.CustomerId) == false)
            {
                //Serialise the customer into JSON
                string newCustomerJson = JsonConvert.SerializeObject(newCustomer);
                //Convert this to http
                var httpContent = new StringContent(newCustomerJson);
                //add headers
                httpContent.Headers.ContentType.MediaType = "application/json";
                httpContent.Headers.ContentType.CharSet = "UTF-8";
                //send data
                using (var httpClient = new HttpClient())
                {
                    var httpResponse = await httpClient.PostAsync(customerUrl, httpContent);
                    Console.WriteLine($"Success status is {httpResponse.IsSuccessStatusCode}");
                }
            }
        }
       static async void GetAllCustomers()
        {
            using(var httpClient = new HttpClient())
            {
                var data = await httpClient.GetStringAsync(customerUrl);

                customers = JsonConvert.DeserializeObject<List<Customer>>(data);
            }
        }

        static async void GetOneCustomer(string customerId)
        {
            using(var httpClient = new HttpClient())
            {
                var data = await httpClient.GetStringAsync(customerUrl + $"/{customerId}");

                customer = JsonConvert.DeserializeObject<Customer>(data);
            }
        }

        static bool GetCustomer(string customerId)
        {
            var customerExists = customers.Where(c => c.CustomerId == customerId).FirstOrDefault();

            if(customerExists == null)
            {
                return false;
            }
            else
            {
                Console.WriteLine("Customer already exists");
                return true;
            }
        }
    }
}
