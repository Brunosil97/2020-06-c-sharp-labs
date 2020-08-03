using System;

namespace lab_27_delegates
{
    class Program
    {
        delegate void Delegate01();

        delegate string Delegate02(int x, bool y);
        static void Main(string[] args)
        {
            //shorter version
            // notice no brackets in method => just a placeholder, dont call it right now
            Delegate01 delegateInstance = Method01;

            Action myOtherDelegateInstance = Method02;

            Delegate02 stringInstance = StringMethod;

            //run
            delegateInstance();
            myOtherDelegateInstance();
            Console.WriteLine(stringInstance(2, true));
        }

        static void Method01()
        {
            Console.WriteLine("Running Method  01");
        }

        static void Method02()
        {
            Console.WriteLine("Running Method  02");
        }

        static string StringMethod(int x, bool y)
        {
            if (x % 2 == 0 && y == true)
            {
                return $"{x} is even";
            }
            else
            {
                return $"{x} is not even";
            }
            
        }
    }
}
