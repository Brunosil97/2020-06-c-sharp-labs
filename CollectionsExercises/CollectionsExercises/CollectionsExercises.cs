using Microsoft.Win32.SafeHandles;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System;
using System.Linq;

namespace CollectionsExercisesLib
{
    public class CollectionsExercises
    {
        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            string answer = "";

            if(num > 0) { answer += queue.Dequeue(); }

            for(int i = 1; i < num; i++)
            {
                if(queue.Count == 0) { break; }
                answer += $", {queue.Dequeue()}";

            }
            return answer;
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            Stack<int> reverser = new Stack<int>();

            foreach(int num in original)
            {
                reverser.Push(num);
            }
            int[] myArray = new int[original.Length];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = reverser.Pop();
            }
            return myArray;
        }
        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            var countD = new Dictionary<char, int>();
      
            string answer = "";

            string inputNumbers = string.Join("", input.ToCharArray().Where(Char.IsDigit));

           
            foreach(char c in inputNumbers)
            {
                if(countD.ContainsKey(c))
                {
                    countD[c]++;
                }
                else
                {
                    countD.Add(c, 1);
                }
            }

            foreach (var item in countD)
            {
                answer += $"[{item.Key}, {item.Value}]";
            }

            return answer;
        }
    }
}