using System;
using System.Collections.Generic;

using System.Text;

using System.Linq;

namespace CollectionsExercisesLib
{
    public class ListExercises
    {
        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {
            List<int> myList = new List<int>();

            for(int i = 1; i <= max; i++)
            {
                if(i % 5 == 0)
                {
                    myList.Add(i);
                }
            }
            return myList;
        }

        // return the average of all the numbers in argList 
        public static double Average(List<double> argList)
        {
            double average = 0;

            if(argList.Count > 1)
            {
                average = argList.Average();
            }

            return average;
        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {
            List<string> myList = new List<string>();

            foreach(string stg in sourceList)
            {
                if(stg[0] == 'A' || stg[0] == 'a')
                {
                    myList.Add(stg);
                }
            }

            return myList;
        }
    }
}

