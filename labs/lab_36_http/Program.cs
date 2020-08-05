using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace lab_36_http
{
    class Program
    {
        static Uri url = new Uri("https://jsonplaceholder.typicode.com/todos/1");
        static Uri url2 = new Uri("https://www.bbc.co.uk");
        static void Main(string[] args)
        {

            //All sync
            //GetDataUsingWebClient();
            //GetPageUsingWebClient();

            //GetPageUsingWebRequest();

            //Async
            // GetDataUsingHttpClient();

            DeserilizeJsonForUser();
        }

       static void DeserilizeJsonForUser()
        {
            var httpClient = new HttpClient();
            var httpResponse = httpClient.GetStringAsync(url);
            var data = httpResponse.Result;

            User user = JsonConvert.DeserializeObject<User>(data);

            Console.WriteLine(user.Title);
        }

        static void GetDataUsingHttpClient()
        {
            var httpClient = new HttpClient();
            //sync at present
            var httpResponse = httpClient.GetStringAsync(url);
            var data = httpResponse.Result;
            Console.WriteLine("\n\n Getting data using HttpClient\n");
            Console.WriteLine(data);

            //Turn from string into JSON object
            //add Newtonsoft.json library

            var json = JObject.Parse(data);

            Console.WriteLine(json["title"]);
            Console.WriteLine(json["completed"]);

        }

        static void GetPageUsingWebClient()
        {
            var webclient = new WebClient { Proxy = null };
            webclient.DownloadFile(url2, "bbcWebPage.html");
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "bbcWebPage.html");

        }

        static void GetDataUsingWebClient()
        {
            var webclient = new WebClient { Proxy = null };
            var data = webclient.DownloadString(url);
            Console.WriteLine(data);
        }

        static void GetPageUsingWebRequest()
        {
            var bbcRequest = WebRequest.Create(url2);
            bbcRequest.Proxy = null;

            var bbcPageResponse = bbcRequest.GetResponse();

            //interegate the response
            Console.WriteLine("BBC page has arrived");
            Console.WriteLine(bbcPageResponse.ContentType);
            Console.WriteLine(bbcPageResponse.ContentLength);

            //Interegate request - page headers
            Console.WriteLine("\n\nGetting Page header information");

            var pageRequestHeaders = bbcPageResponse.Headers.AllKeys;

            //values
            foreach(var key in pageRequestHeaders)
            {
                Console.WriteLine(key);
                foreach (var value in bbcPageResponse.Headers.GetValues(key))
                {
                    Console.WriteLine($"\t\t : {value}");
                }
            }
           

        }
    }

    public class User
    {
            public int UserId { get; set; }
            public int Id { get; set; }
            public string Title { get; set; }
            public bool Completed { get; set; }

    }
}
