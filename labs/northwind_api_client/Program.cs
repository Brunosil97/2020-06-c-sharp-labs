using Newtonsoft.Json;
using northwind_api_client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

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

            //Generate random customerId which does not already exist
            //Five alpha characters



            //Post a customer
            var newCustomer = new Customer()
            {
                CustomerId = $"NEW05",
                ContactName = "Bruno",
                CompanyName = "My Comapny",
                City = "London",
                Country = "UK",

            };

            newCustomer.ContactTitle = "Mr";
            newCustomer.Region = "Greater London";
            newCustomer.PostalCode = "KT4 8NY";

            GetAllCustomers();
            Thread.Sleep(2000);

            //PostCustomerAsync(newCustomer);
            Thread.Sleep(2000);
            

            Console.WriteLine($"customer list count is {customers.Count}");

            //update
            UpdateCustomerAsync(newCustomer);

            Thread.Sleep(2000);

            GetOneCustomer(newCustomer.CustomerId);

            Thread.Sleep(2000);

            Console.WriteLine($"Updated customer now has region : {customer.Region}");
            //deleteAsync void
            //DeleteCustomerAsync("NEW03");

            
            //deleteAsync return task
            //DeleteCustomerAsync2("NEW04").Wait();
            //OR with main async
            //var response = await DeleteCustomerAsync2("NEW04");
        }

        static string RandomId()
        {
            int length = 5;
            char letter;

             Random random = new Random();
             StringBuilder str_build = new StringBuilder();

            for(int i = 0; i <= length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            return str_build.ToString();
        }
        static async void UpdateCustomerAsync(Customer customer)
        {          
            string customerJson = JsonConvert.SerializeObject(customer);
            var httpContent = new StringContent(customerJson);

            httpContent.Headers.ContentType.MediaType = "application/json";
            httpContent.Headers.ContentType.CharSet = "UTF-8";

            using (var httpClient = new HttpClient())
            {
                var data = await httpClient.PutAsync($"{customerUrl}/{customer.CustomerId}", httpContent);
                Console.WriteLine($"Success status is {data.IsSuccessStatusCode}");
            }
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
        static async void DeleteCustomerAsync(string customerId)
        {
            if (GetCustomer(customerId))
            {
                using (var httpClient = new HttpClient())
                {
                    var data = await httpClient.DeleteAsync(customerUrl + $"/{customerId}");
                    Console.WriteLine($"Delete was successful: {data.IsSuccessStatusCode}");
                }
            }
            else
            {
                Console.WriteLine($"Customer {customerId} does not exist");
            }
        }
        static async Task<HttpResponseMessage> DeleteCustomerAsync2(string customerId)
        {

            if (GetCustomer(customerId))
            {
                using (var httpClient = new HttpClient())
                {
                    var data = await httpClient.DeleteAsync(customerUrl + $"/{customerId}");
                    Console.WriteLine($"Delete was successful: {data.IsSuccessStatusCode}");

                    return data;
                }
            }
            else
            {
                Console.WriteLine($"Customer {customerId} does not exist");
                return null;
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
