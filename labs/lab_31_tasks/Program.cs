using System;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace lab_31_tasks
{
    class Program
    {
        static Stopwatch s = new Stopwatch();

       delegate void MyDelegate();
        static void Main(string[] args)
        {
            /*
             Tasks:
            
            Async - Main() thread

            Sync - 

            Process - exe running application which is able to send commands to CPU for processing
                Thread ==> set of instructions bundled up and sent to CPU for processing
                Main(){
                    subThread() ==> execute as different process computer
                }

            C#
                Threading - manually created thread

                Tasks ==> hard work removed ==> easy for programmer to work with sub threads/ sub tasks

            Key words:
                Process          - running exe
                Application      - run by user and runs in foreground
                Service          - run by computer at start up and runs in background (DNS, VPN. website)
                Thread           - set of instructions sent to CPU for processing
                Single-Threaded  - Runs on the main thread only
                Multi-Threaded   - Can take advantage of multi core CPUs which can run multiple threads simultaneously
            */

            s.Start();

            var thread = new Thread(
                () => {
                    //Thread.Sleep(3000);
                    Console.WriteLine($"This is a thread {s.ElapsedMilliseconds}"); }
                );


            var task01 = new Task(
                () =>
                {
                    //Thread.Sleep(1000);
                    Console.WriteLine($"This is a task {s.ElapsedMilliseconds}");
                });

            //create and run at same time
            var task02 = new Task(
                () =>
                {
                    //Thread.Sleep(2000);
                    Console.WriteLine($"This is task 2 {s.ElapsedMilliseconds}");
                }
                );

            var instance = new MyDelegate(DoThis);

            var task03 = new Task(
               new Action(instance)
            );


            s.Start();

            thread.Start();

            task01.Start();

            task02.Start();

            task03.Start();

            Console.WriteLine($"Program has ended {s.ElapsedMilliseconds}");
            Console.ReadLine();

            static void DoThis()
            {
                Console.WriteLine($"Im doing this at {s.ElapsedMilliseconds}");
            }
        }
    }
}
