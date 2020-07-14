using System;
using System.Linq;

namespace IterationLib
{
    public class Highest
    {
        public static int HighestWhileLoop(int[] nums)
        {
            int i = 0;
            int max = int.MinValue; // this makes it the lowest possible number
            while (i < nums.Length)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                   
                }
                i++;
            }
            return max;
            // this method should use a while loop

        }

        public static int HighestForLoop(int[] nums)
        {
            int max = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] > max)
                {
                    max = nums[i];
                }
            }
            return max;
        }

        public static int HighestForEachLoop(int[] nums)
        {
            int max = 0;
            // this method should use a for-each loop
            foreach(int num in nums)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }

        public static int HighestDoWhileLoop(int[] nums)
        {
            int i = 0;
            int max = 0;
            do
            {
                if (nums[i] > max)
                {
                    max = nums[i];

                }
                i++;
            }
            while (i < nums.Length);

            return max;
        }
    }
}