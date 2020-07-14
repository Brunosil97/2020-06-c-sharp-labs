using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace lab_19_iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(int i = 100; i >= 0; i--) // for loop that counts down
            //{
            //    Console.WriteLine(i);
            //}

            int[] myArray = { 10, 20, 30 }; 
            for(int i = 0; i < myArray.Length; i++) //loops through the array and its values
            {
                Console.WriteLine(myArray[i]);
            }

            foreach(int item in myArray) //same as for loop, for each item in the array, print them out
            {
                Console.WriteLine(item);
            }

            //While loops
            //will do loops when condition is true. The loop body must change to get out of the loop

            int counter = 10;
            while(counter < 10)
            {
                Console.WriteLine(counter * 10);
                counter++;
            }

            //Do while
            //the statement is run at least once. It runs until condition is no longer true. It runs the code then it tests
            do
            {
                Console.WriteLine(counter);
                counter++;
            }
            while (counter < 10);

            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);

            string egoNish = "NISH IS KING";
            foreach (char letter in egoNish)
            {
                Console.WriteLine(letter.ToString().ToLower());
            } //also like this 
            //for (int i = 0; 0 < egoNish.Length; i++)
            //{
            //    Console.WriteLine(egoNish.ToLower()[i]);
            //}

            //Breaking out of loops
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if(i == 5) //when condition is met we can break out of loop
                {
                    //break;
                    continue; //continues through loop
                }
            }

            //goto statements
            //Console.WriteLine("Hello");
            //goto a: //sends it to a, but will make next line unreachable
            //Console.WriteLine("World");
            //a:
            //Console.WriteLine("and Eng-66");

            //return statemens - we can permatuerly exit the method by executing a return statement
            //and returning the required value

            for(int i = 0; i <= 20; i++)
            {
                Console.WriteLine(i);
                if(i % 15 == 0)
                {
                    break;
                }
            }
            LoopHomeWork();
        }
        //- Create a loop that outputs the numbers 1 to 300 to the screen.
        //-For every 100th number, have the program output your name, a greeting, or anything else you want to the screen.
        //- Same as the one above, but for every 5th, 105th, 205th, etc number.
        //- Count down from 50 to 0 and output the numbers to the screen.
        //- Implement the four labs above in one file, but ask the user which option(1 - 4) is chosen, and run the appropriate task
        public static void LoopHomeWork()
        {
            Console.Write("Type your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            Console.WriteLine("Enter a number between 1-4");
            Console.WriteLine("1: Create a loop for 1 - 300");
            Console.WriteLine("2: For every 100th number, output your name and a greeting");
            Console.WriteLine("3: For every 5h, 105th, 205th output name and a greeting");
            Console.WriteLine("4: Count down from 50 to 0");

            int numInput = Convert.ToInt32(Console.ReadLine());
 
            if (numInput == 1)
            {
                for(int i = 1; i < 301; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else if(numInput == 2)
            {
                for(int i = 1; i < 301; i++)
                {
                    if(i == 100 || i == 200 || i == 300)
                    {
                        Console.WriteLine($"Welcome to my loop, I'm {myFirstName}");
                    }
                }
            }
            else if(numInput == 3)
            {
                for (int i = 1; i < 301; i++)
                {
                    if (i == 5 || i == 105 || i == 205)
                    {
                        Console.WriteLine($"Welcome to my loop, I'm {myFirstName}");
                    }
                }
            }
            else if (numInput == 4)
            {
                for (int i = 50; i >= 0; i--)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
