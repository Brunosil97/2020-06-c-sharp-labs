using System;

namespace lab_26_delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Delegates

            //1. Placeholder for one or more methods
            //2. Can use in annoymous 'lambda' expressions, very usefull particually with 'async' web calls
            //3. Link to events ==> EVENT fires eg button click ==> all methods must match pattern given in our delegate
            //               void myDelegate01(); any methods would have to match pattern void myMethod();
            //               string          (int)                                       string          (int)


            //Create an event ==> and run given methods
            //1. Create Delegate
            //2. Create delegate instance
            var delegateInstance = new MyDelegate01(Method01);

            //3. Run the delegate instance and will call the method
            delegateInstance();
        }


        delegate void MyDelegate01(); //Maatches method of void and no parameters

        //These are Action methods: Don't return anything or take anything

        static void Method01()
        {
            Console.WriteLine("I am Method01");
        }

        static void Method02()
        {
            Console.WriteLine("I am Method02");
        }
    }
}
