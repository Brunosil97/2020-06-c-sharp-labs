#define RUNNINGTEST01
using System;


namespace lab_03_dot_net_core_hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            #region maincodeblock
            Console.WriteLine("Hello World!");
            int[] myArray = {1,2,3,4};
            foreach(var item in myArray) {
                 Console.WriteLine(item);
        }
            int total = 0;

            #region subloop

            for (int i=0; i < 5; i++)
            {
                total += i;
            }
            #endregion subloop


            #endregion maincodeblock

            //compile if the build is debug build

#if DEBUG
            Console.WriteLine("this is code only compiled in debug mode");

#endif

#if RUNNINGTEST01
            Console.WriteLine("Running test01" );
#endif
        }
    }
}
