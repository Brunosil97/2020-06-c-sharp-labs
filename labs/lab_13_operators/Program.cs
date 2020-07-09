using System;

namespace lab_13_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //int x = 1;
            //int y = x++;
            //int a = 1;
            //int b = ++x;


            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //var average = (2 + 5 + 1 + 8) / 4;
            //Console.WriteLine(average);

            //var a = 5 / 2;
            //var b = 5.0 / 2;
            //var c = 5 / 3;

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            var days = 26 & 7;
            //remainder of days left within the weeks
            var weeks = 26 / 7;

            Console.WriteLine($"Weeks: {weeks} and Days: {days}");

            Console.WriteLine(5 & 1);  //this displays one, comparing th binary
            Console.WriteLine(5 | 1);  //comparing 5 and 1 and will display 5
            Console.WriteLine(5 ^ 1);  //returns 4

            Console.WriteLine(9 << 3); //returns 72
            Console.WriteLine(9 >> 3); //returns 1

            int x = 3;
            int y = 2;

            Console.WriteLine(x += y);
            Console.WriteLine(x *= y);
            Console.WriteLine(x /= y);
            Console.WriteLine(x %= y);

            int a = 5, b = 3, c = 4;
            c += +a++ + ++b;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
