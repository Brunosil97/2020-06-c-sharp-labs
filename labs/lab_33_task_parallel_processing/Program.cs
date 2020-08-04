using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace lab_33_task_parallel_processing
{
    class Program
    {
        delegate void MyDelegate();
        static void Main(string[] args)
        {
            Stopwatch s = new Stopwatch();
            //C# has a library to help with task 'parallel' processing

            //Firstly ==> running methods in parallel
            Action instance01 = OverNightTask01;
            Action instance02 = OverNightTask02;
            Action instance03 = OverNightTask03;
            Action instance04 = OverNightTask04;
            Action instance05 = OverNightTask05;

            Parallel.Invoke(
                () => { }, //can call the methods eithin
                () => { },
                () => { },
                () => { },
                () => { },
                instance01,
                instance02,
                instance03,
                instance04,
                instance05
                );

            //parallel for
            var taskArray = new Task[32];
            for (int i = 0; i < taskArray.Length; i++)
            {
                var j = i;
                taskArray[j] = Task.Run(
                    () => {
                        Thread.Sleep(5);
                        Console.WriteLine($"Task {j} has completed at {s.ElapsedMilliseconds}"); }
                    );
            }
            Console.WriteLine($"all completed at {s.ElapsedMilliseconds}");
            Console.ReadLine();
        }

        static void OverNightTask01()
        {
            Console.WriteLine("Proccessing overnight task 01");
        }

        static void OverNightTask02()
        {
            Console.WriteLine("Proccessing overnight task 02");
        }

        static void OverNightTask03()
        {
            Thread.Sleep(500);
            //still in order, waits for 3 to finish before continuing
            Console.WriteLine("Proccessing overnight task 03");
        }

        static void OverNightTask04()
        {
            Console.WriteLine("Proccessing overnight task 04");
        }

        static void OverNightTask05()
        {
            Console.WriteLine("Proccessing overnight task 05");
        }
    }
}
