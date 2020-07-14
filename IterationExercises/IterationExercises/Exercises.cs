using System;
using System.Linq;

namespace IterationLib
{

    public class Program
    {
       
        public static void Main(string[] nums)
        {
            //ignore
        }
    }
    public class Exercises
    {
        // returns the lowest number in the array nums
        public static int Lowest(int[] nums)
        {
            int ans;

            if(nums.Length == 0)
            {
                ans = int.MaxValue;
            }
            else
            {
                ans = nums.Min();
            }
            return ans;
        }

        // returns the sum of all numbers between 1 and n inclusive that are divisible by either 2 or 5
        public static int SumEvenFive(int max)
        {
            int sum = 0; 
            for(int i = 0; i <= max; i++)
            {
                if(i % 2 == 0 || i % 5 == 0)
                {
                    sum+= i;
                }
            }
            return sum;
        }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters(string input)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            foreach(char ch in input)
            {
                if(ch == 'A')
                {
                    a++;
                }
                else if (ch == 'B')
                {
                    b++;
                }
                else if (ch == 'C')
                {
                    c++;
                }
                else if (ch == 'D')
                {
                    d++;
                }

            }
            return $"A:{a} B:{b} C:{c} D:{d}";
        }
    }
}