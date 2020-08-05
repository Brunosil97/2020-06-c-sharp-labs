using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading;

namespace lab_37_http_deserilize
{
    public class Todo
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }

    }
    class Program
    {
        static Uri todosUrl = new Uri("https://jsonplaceholder.typicode.com/todos");

        static List<Todo> todos = new List<Todo>();
        static List<Todo> todosAsync = new List<Todo>();
        static void Main(string[] args)
        {
            //Sync
            GetTodos();

            Console.WriteLine($"Synchronously we have obtained {todos.Count} records");

            //Async
            var s = new Stopwatch();
            s.Start();
            GetTodosAsync();

            Console.WriteLine($"Asynchronously we have obtained {todosAsync.Count} records at {s.ElapsedMilliseconds}");

            Thread.Sleep(2000);
            Console.WriteLine($"Asynchronously we have obtained {todosAsync.Count} records at {s.ElapsedMilliseconds}");
            s.Stop();
        }


        static void GetTodos()
        {
            using (var httpClient = new HttpClient())
            {
                var httpResponse = httpClient.GetStringAsync(todosUrl);
                var data = httpResponse.Result;

                todos = JsonConvert.DeserializeObject<List<Todo>>(data);
            }
        }

        static async void GetTodosAsync()
        {
            using(var httpClient = new HttpClient())
            {
                var data = await httpClient.GetStringAsync(todosUrl);
           
                todosAsync = JsonConvert.DeserializeObject<List<Todo>>(data);
            }
        }
    }
}
