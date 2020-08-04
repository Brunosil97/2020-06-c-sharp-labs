using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab_34_async_and_await
{
    class Program
    {
        static Stopwatch s = new Stopwatch();
        static List<string> fileOutput = new List<string>();
        static List<string> streamOutput = new List<string>();

        static void Main(string[] args)
        {
            /*
            SYNC code - Line by Line
            
            Async Code
                async void DoThisAsync() {
                     var output = await ReadFileAsync("thisfile.txt")
                     var output = await GetHttp/JsonDataAsync(url)
                }
            //walkthrough : read file sync and async

            1. Create text file 10,000 lines
            2. method to read text file to array
            3. call this method from main()
            4. Time application start to finish
            */
            s.Start();
            //File.Delete("data.txt");

            if (!File.Exists("data.txt"))
            {
                for(int i = 0; i < 1000; i++)
                {
                    File.AppendAllText("data.txt", $"adding a new line at {i}");
                }
            }

            Console.WriteLine($"File created took {s.ElapsedMilliseconds}");

         
            //Synchronous read
            var array = ReadTextFileToArray();

            Console.WriteLine($"sync read took {s.ElapsedMilliseconds}");

            //streamreader read
            s.Restart();

            List<string> fileOutput = new List<string>();

            using (var reader = new StreamReader("data.txt"))
            {
                while (!reader.EndOfStream)
                {
                    fileOutput.Add(reader.ReadLine());
                }
            }

            Console.WriteLine($"streamreader to list took {s.ElapsedMilliseconds}");

            //streamreader read to stringbuilder
            s.Restart();
            var stringBuilder = new StringBuilder();
            using(var reader = new StreamReader("data.txt"))
            {
                while (!reader.EndOfStream)
                {
                    stringBuilder.Append(reader.ReadLine());
                }
            }

            string fileOutput2 = stringBuilder.ToString();
            Console.WriteLine($"Streamreader to string took {s.ElapsedMilliseconds}");

            //async read - basic file read async
            s.Restart();
            ReadTextToArrayAsync();
            Console.WriteLine($"Async file read took {s.ElapsedMilliseconds} with {fileOutput.Count}");

            s.Restart();
            StreamReadTextFileAsync();
            Console.WriteLine($"Async stream read took {s.ElapsedMilliseconds} with {streamOutput.Count}");

            //final lab - get results but can you turn this into proper async
            //(This way only partly works - task overnight to improve it)
            s.Restart();
            //this returns a 'task'
            var arrayOutput = ReturnTextToArrayAsync();

            Console.WriteLine($"Async array returned in {s.ElapsedMilliseconds} with {arrayOutput.Result.Length} records");

        }

        static string[] ReadTextFileToArray()
        {
            var array = File.ReadAllLines("data.txt");
            return array;
        }

        static async void ReadTextToArrayAsync()
        {
            var array = await File.ReadAllLinesAsync("data.txt");
            fileOutput = array.ToList();
        }

        //This one returns data with task
        static async Task<string[]> ReturnTextToArrayAsync()
        {
            var array = await File.ReadAllLinesAsync("data.txt");
            return array;
        }

        static async void StreamReadTextFileAsync()
        {
            
            using (var reader = new StreamReader("data.txt"))
            {
                while (!reader.EndOfStream)
                {
                    //var array = await File.ReadAllLinesAsync("data.txt");
                    //streamOutput = array.ToList();
                    streamOutput.Add(await reader.ReadLineAsync());
                }
            }
        }
    }
}
