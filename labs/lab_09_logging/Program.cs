using System;
using System.IO;

namespace lab_09_logging
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("Output.log", $"Printing i");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                File.AppendAllText("Output.log", $"The value of i is {i}");
            }
        }
    }
}
