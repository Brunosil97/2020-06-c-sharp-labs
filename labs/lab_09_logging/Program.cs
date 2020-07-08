using System;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace lab_09_logging
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("Output.log", $"Printing i\n\n");
            #region loop with stopwatch

            var stopwatch = new Stopwatch();
            stopwatch.Start();


            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                File.AppendAllText("Output.log", $"The value of i is {i} at {DateTime.Now}\n");
                Thread.Sleep(500);
            }

            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            Console.WriteLine(stopwatch.ElapsedTicks);

            #endregion loop with stopwatch

            //read our log file
            //1.Simple way - just all as one string
            Console.WriteLine($"\n\nOutput as single string\n\n");
            string outputAsString = File.ReadAllText("Output.log");
            Console.WriteLine(outputAsString);

            //2. Each line pushed into array
            Console.WriteLine($"\n\nOutput as array\n\n");
            string[] outPutArray = File.ReadAllLines("Output.log");
            foreach (string line in outPutArray)
            {
                Console.WriteLine(line);
            }
        }
    }
}
