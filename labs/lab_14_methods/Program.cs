using System;

namespace lab_14_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DoThis();
            var output = StringMethod();
            SquareNumber(x: 4, y: "This is a square method");
            OrderPizza(true,true);
            OrderPizza(banana: true, pepperoni: true, pineapple: false);
            var results = ReturnTwothings(10, "Bruno", out bool isLarge);
            Console.WriteLine(isLarge);
        }

        public static void DoThis()
        {
            Console.WriteLine("I am a method");
        }

        public static string StringMethod()
        {
            return "This is a string method";
        }

        public static int SquareNumber(int x, string y)
        {
            Console.WriteLine(y);
            return x * x;
        }

        static void OrderPizza(bool pepperoni, bool pineapple, bool banana = false)
        {
            if (pepperoni == true && pineapple == true && banana == true)
            {
                Console.WriteLine("Delicious!");
            }
            if (pepperoni == true && pineapple == false && banana == true)
            {
                Console.WriteLine("Where's the pineapple");
            }
            if (pepperoni == false && pineapple == false && banana == false)
            {
                Console.WriteLine("Idiots messed up");
            }
            if (pepperoni == true && pineapple == true && banana == false)
            {
                Console.WriteLine("Where's the banana");
            }
        }

        public static int ReturnTwothings(int x, string y, out bool z)
        {
            Console.WriteLine(y);
            z = (x > 10);
            return x * x;
        }
    }
}
