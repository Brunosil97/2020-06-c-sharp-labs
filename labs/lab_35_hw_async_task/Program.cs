using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;

namespace lab_35_hw_async_task
{
    public class Coffee
    {
    }

    public class Juice
    {
    }

    public class Toast
    {
    }

    public class Bacon
    {
    }

    public class Egg
    {
    }
    public class CustomData
    {
        public int CreationTime;
        public int Name;
        public int ThreadNum;
    }
    public class Program
    {
        static Stopwatch stopwatch = new Stopwatch();
        //static async Task Main(string[] args)

        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Inside Main";

            stopwatch.Start();

            Task task01 = Task.Run(() => Console.WriteLine($"Hello from Task 1, running at: {stopwatch.ElapsedMilliseconds}"));

            stopwatch.Restart();
            Console.WriteLine($"Hello from thread {Thread.CurrentThread.Name}, running at: {stopwatch.ElapsedMilliseconds}");

            task01.Wait();

            stopwatch.Restart();

            Task[] taskArray = new Task[10];
            for (int i = 0; i < taskArray.Length; i++)
            {
                taskArray[i] = Task.Factory.StartNew((Object obj) =>
                {
                    CustomData data = obj as CustomData;
                    if (data == null)
                        return;
                    data.ThreadNum = Thread.CurrentThread.ManagedThreadId;
                },
                new CustomData() { Name = i, CreationTime = DateTime.Now.Second });
            }

            Task.WaitAll(taskArray);
            foreach (var task in taskArray)
            {
                var data = task.AsyncState as CustomData;
                if (data != null)
                    Console.WriteLine($"Task {data.Name} created at {data.CreationTime}, ran on {data.ThreadNum}, stopwatch: {stopwatch.ElapsedMilliseconds}");
            }


            stopwatch.Restart();

            MakeBreakfast();

            Console.ReadLine();


        }

        public static async void MakeBreakfast()
        {
            await CookEggs();

            CookBacon();
            ToastBread();
        }
        public static async Task<bool> CookEggs()
        {
            bool result = false;
            await Task.Run(
                () => {
                    Thread.Sleep(2000);
                    Console.WriteLine("eggs cooked");
                    result = true;
                });
            return result;
        }

        public static async void CookBacon()
        {
            await Task.Run(
                () => {
                    Thread.Sleep(2000);
                    Console.WriteLine("Bacon cooked");
                });
        }

        public static async void ToastBread()
        {
            await Task.Run(
               () => {
                   Thread.Sleep(2000);
                   Console.WriteLine("Bread toasted");
               });
        }

        //    Coffee cup = PourCoffee();
        //    Console.WriteLine("coffee is ready");

        //    var eggsTask = FryEggsAsync(2);
        //    var baconTask = FryBaconAsync(3);
        //    var toastTask = MakeToastWithButterAndJamAsync(2);

        //    var breakfastTasks = new List<Task> { eggsTask, baconTask, toastTask };
        //    while (breakfastTasks.Count > 0)
        //    {
        //        Task finishedTask = await Task.WhenAny(breakfastTasks);
        //        if (finishedTask == eggsTask)
        //        {
        //            Console.WriteLine("eggs are ready");
        //        }
        //        else if (finishedTask == baconTask)
        //        {
        //            Console.WriteLine("bacon is ready");
        //        }
        //        else if (finishedTask == toastTask)
        //        {
        //            Console.WriteLine("toast is ready");
        //        }
        //        breakfastTasks.Remove(finishedTask);
        //    }

        //    Juice oj = PourOJ();
        //    Console.WriteLine("oj is ready");
        //    Console.WriteLine("Breakfast is ready!");
        //}

        //static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
        //{
        //    var toast = await ToastBreadAsync(number);
        //    ApplyButter(toast);
        //    ApplyJam(toast);

        //    return toast;
        //}

        //private static Juice PourOJ()
        //{
        //    Console.WriteLine("Pouring orange juice");
        //    return new Juice();
        //}

        //private static void ApplyJam(Toast toast) =>
        //    Console.WriteLine("Putting jam on the toast");

        //private static void ApplyButter(Toast toast) =>
        //    Console.WriteLine("Putting butter on the toast");

        //private static async Task<Toast> ToastBreadAsync(int slices)
        //{
        //    for (int slice = 0; slice < slices; slice++)
        //    {
        //        Console.WriteLine("Putting a slice of bread in the toaster");
        //    }
        //    Console.WriteLine("Start toasting...");
        //    await Task.Delay(3000);
        //    Console.WriteLine("Remove toast from toaster");

        //    return new Toast();
        //}

        //private static async Task<Bacon> FryBaconAsync(int slices)
        //{
        //    Console.WriteLine($"putting {slices} slices of bacon in the pan");
        //    Console.WriteLine("cooking first side of bacon...");
        //    await Task.Delay(3000);
        //    for (int i = 0; i < slices; i++)
        //    {
        //        Console.WriteLine("flipping a slice of bacon");
        //    }
        //    Console.WriteLine("cooking the second side of bacon...");
        //    await Task.Delay(3000);
        //    Console.WriteLine("Put bacon on plate");

        //    return new Bacon();
        //}

        //private static async Task<Egg> FryEggsAsync(int howMany)
        //{
        //    Console.WriteLine("Warming the egg pan...");
        //    await Task.Delay(3000);
        //    Console.WriteLine($"cracking {howMany} eggs");
        //    Console.WriteLine("cooking the eggs ...");
        //    await Task.Delay(3000);
        //    Console.WriteLine("Put eggs on plate");

        //    return new Egg();
        //}

        //private static Coffee PourCoffee()
        //{
        //    Console.WriteLine("Pouring coffee");
        //    return new Coffee();
        //}
    }
}