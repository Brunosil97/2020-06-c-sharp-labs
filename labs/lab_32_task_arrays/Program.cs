using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace lab_32_task_arrays
{
    class Program
    {
        static Stopwatch s = new Stopwatch();
        static void Main(string[] args)
        {
            //Single tasks - not much benefit
            //array of tasks => each one can complete at its own lesiure
            s.Start();


            var taskArray = new Task[5];

            taskArray[0] = Task.Run(
                () => { Console.WriteLine($"Task 0 completed"); }
                );

            taskArray[1] = Task.Run(
              () => { Console.WriteLine($"Task 1 completed"); }
              );

            taskArray[2] = Task.Run(
              () => { Console.WriteLine($"Task 2 completed"); }
              );

            taskArray[3] = Task.Run(
              () => {
                 // Thread.Sleep(500);
                  Console.WriteLine($"Task 3 completed"); }
              );

            taskArray[4] = Task.Run(
              () => {
                  //Thread.Sleep(500);
                  Console.WriteLine($"Task 4 completed"); }
              );

            //wait for individual tasks
            var oneTask = Task.Run(
                () => {
                    ////Thread.Sleep(800);
                    Console.WriteLine($"Individual task completed {s.ElapsedMilliseconds}");}
                );

            //get data back with Task.Result
            var getDataBack = Task<string>.Run(
                () =>
                {
                    return "Here is some data returned from background task";
                });

            //wait for any of them to complete
            Task.WaitAny(taskArray);
            Console.WriteLine($"First task cmpleted at {s.ElapsedMilliseconds}");

            //Wait for them all
            Task.WaitAll(taskArray);

            Console.WriteLine($"Program terminate at {s.ElapsedMilliseconds}" );

            oneTask.Wait();

            Console.WriteLine($"background data returned at time {s.ElapsedMilliseconds} - data is {getDataBack.Result}");

            Console.ReadLine();

            
        }
    }
}
