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
            for(int i = 0; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);

            string egoNish = "NISH IS KING";
            foreach(char letter in egoNish)
            {
                Console.WriteLine(letter.ToString().ToLower());
            } //also like this 
            for(int i = 0; 0 < egoNish.Length; i++)
            {
                Console.WriteLine(egoNish.ToLower()[i]);
            }
        }
    }
}
