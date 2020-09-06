using System;

namespace TechInterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tech Interview!");

            Console.WriteLine("Quick Fire: 1");
            //FizzBuzz(100);

            Console.WriteLine("Quick Fire: 2");
            Loops(300);
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

        static void Loops(int number)
        {
            var name = "Bruno";
            var greeting = "How are you!";
            

            for(int i = 0; i <= number; i++)
            {
                if (i >= 300)
                {
                    break;
                }

                if (i < 5)
                {
                    //skip console logging the first 5 iterations
                    continue;
                }    
                else if (i == 100 || i == 200 || i == 300) 
                { 
                    Console.WriteLine($"Hi my name is {name}. {greeting} ");
                    continue;
                    //print out the greeting instead of printing greeting AND the number
                }

                else if(i == 5 || i == 105 || i == 205)
                {
                    for (int num = 20; num > 0; num--) { Console.WriteLine($"Countdown: {num}"); }
                }

                Console.WriteLine(i);
            }

        }
    }
}
