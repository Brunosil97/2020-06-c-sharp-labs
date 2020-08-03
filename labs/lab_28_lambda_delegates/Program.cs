using System;

namespace lab_28_lambda_delegates
{
    class Program
    {
        delegate string MyDelegate(string x, int y);

        static void Main(string[] args)
        {
            MyDelegate instance = MyMethod;
            Console.WriteLine(instance("Bruno", 5));

            //use anoymous method instead with lambda
            MyDelegate instance2 = (aName, y) => {
                return $"Thanks {aName}, You have entered number {y}";
            };

            Console.WriteLine(instance2("bob", 33));
        }

        static string MyMethod(string aName, int y)
        {
            return $"Thanks {aName}, You have entered number {y}";
        }
    }
}
