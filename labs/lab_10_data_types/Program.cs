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

            //checked
            //{
            //    float sum = 0;

            //    for(int i = 0; i < 100; i++)
            //    {
            //        sum += 1 / 2.0f;
            //    }
            //    Console.WriteLine("1/2 added 100 times: " + sum);
            //    Console.WriteLine("1/2 multipled by 100: " + 1/3.0f *1000);
            //}

            //float num = float.NaN;
            //Console.WriteLine(num);

            string bruno = "Bruno";
            char firstLetter = 'b';
            int firstLetterAsNumber = firstLetter;
            Console.WriteLine(firstLetterAsNumber);

            double x = 3.14;
            float y = (float)x;
            Console.WriteLine(y);

            bool likeApples = true;
            Console.WriteLine(likeApples);
            double likeApplesAsDouble = System.Convert.ToInt32(likeApples);
            Console.WriteLine(likeApplesAsDouble);

            char initial = 'M';
            int mCode = initial;
            Console.WriteLine(mCode);
            Console.WriteLine((char)mCode);

            double pi = 3.141592;
            pi = Math.Round(pi, 3);
            Console.WriteLine(pi);

            int num = -5;
            ulong longNum = (ulong)num;
            Console.WriteLine(longNum);

            char four = '4';
            int fourNum = four - '0';
            Console.WriteLine(fourNum);
        }
    }
}
