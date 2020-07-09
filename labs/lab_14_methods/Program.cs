using System;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Runtime.Versioning;

namespace lab_14_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //DoThis();
            //var output = StringMethod();
            //SquareNumber(x: 4, y: "This is a square method");

            //OrderPizza(true, true);
            //OrderPizza(banana: true, pepperoni: true, pineapple: false);

            //var results = ReturnTwothings(10, "Bruno", out bool isLarge);
            //Console.WriteLine(isLarge);
            //Console.WriteLine(results);

            //var myTuple = (fName: "Bruno", lName: "Silva", age: 23);
            //Console.WriteLine(myTuple.lName);

            //var results2 = DoThisWithTuple(10, "Bruno");
            //Console.WriteLine(results2);
            //Console.WriteLine(results2.xsquare);
            //var (square, greaterThan10) = DoThisWithTuple(4, "silva");
            //Console.WriteLine(greaterThan10);

            //Console.WriteLine(Add(3, 4,3));
            //Console.WriteLine(Add(6,6));

            var tripleResult = TripleCalc(1, 1, 1, out int sum);
            Console.WriteLine(tripleResult);
            Console.WriteLine(sum);

            var (sumTuple, product) = TripleCalc(1, 1, 2);
            Console.WriteLine(sumTuple);
            Console.WriteLine(product);
        }

        public static int TripleCalc(int a , int b, int c, out int sum)
        {
            sum = a + b + c;
            return a * b * c;
        }

        public static (int sumTuple, int product) TripleCalc(int a, int b, int c)
        {
            return (a + b + c, a*b*c);
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Add(int a , int b, int c)
        {
            return a + b + c;
        }

        public static (int xsquare, bool y_more_10) DoThisWithTuple(int x, string y)
        {
            Console.WriteLine(y);
            var z = (x > 10);

            return (x * x, z);
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
