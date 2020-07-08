using System;

namespace lab_10_data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            int biggestValue = int.MaxValue;
            long longBiggestValue = long.MaxValue;
            //checked
            //{
            //    int a = Int32.MaxValue;
            //    int b = a + 1;
            //    Console.WriteLine(a);
            //    Console.WriteLine(b);
            //}

            checked
            {
                float sum = 0;

                for(int i = 0; i < 100; i++)
                {
                    sum += 1 / 2.0f;
                }
                Console.WriteLine("1/2 added 100 times: " + sum);
                Console.WriteLine("1/2 multipled by 100: " + 1/3.0f *1000);
            }
        
        }
    }
}
