using System;

namespace lab_29_basic_events
{
    class Program
    {
        delegate void MyDelegate();
        static event MyDelegate MyEvent;

        static event MyDelegate MathEvent;
        static void Main(string[] args)
        {
            //Events ==> Link to multiple methods
            //Events ==> external to program
            //User Events 
            // - onClick
            // - onKeyDown/up/press
            // - doubleClick
            // - mouseOver

            //Data Events
            // - onLoad
            // - onData
            // - arrive
            // - track and complete
            // - OnDataComplete
            // - notifications

            //1. Create delegate (specify methods which can run)
            //2. create 'null' event
            //3. add/remove methos using += or -=. Order matters => methods fire in this order
            MyEvent += Method01;
            MyEvent += Method02;
            MyEvent += Method03;

            MathEvent += add;
            MathEvent += multiply;


            //call the event
            MyEvent();
            MathEvent(2, 3);
        }

        static string add(int x, int y)
        {
            return $"the sum of {x} and {y} is {x + y}";
        }
        
        static string multiply(int x, int y)
        {
            return $"the sum of {x} and {y} multipled is {x * y}";
        }

        static void Method01()
        {
            Console.WriteLine($"Running method 01");
        }

        static void Method02()
        {
            Console.WriteLine($"Running method 02");
        }

        static void Method03()
        {
            Console.WriteLine($"Running method 03");
        }
    }
}
