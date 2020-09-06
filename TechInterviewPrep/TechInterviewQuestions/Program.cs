using System;

namespace TechInterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tech Interview!");

            Console.WriteLine("Quick Fire: 1");
            FizzBuzz(100);
        }

        static void FizzBuzz(int number)
        {
            for(int i = 0; i < number; i++)
            {
                if (i % 15 == 0) { Console.WriteLine("FizzBuzz"); }
                else if (i % 5 == 0) { Console.WriteLine("Buzz"); }
                else if (i % 3 == 0) { Console.WriteLine("Fizz"); }
                else { Console.WriteLine(i); }
            }
        }
    }
}
