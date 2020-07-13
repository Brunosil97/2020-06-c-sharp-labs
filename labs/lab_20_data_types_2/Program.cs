using System;

namespace lab_20_data_types_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //var tps = TimeSpan.TicksPerSecond; // how many ticks in a second
            //var nowInTicks = DateTime.Now.Ticks; //how many ticks since the default of date time

            //Console.WriteLine(tps);
            //Console.WriteLine(nowInTicks);

            var d = new DateTime(); //new date object mapped to midnight, 1 january 0001

            var d1 = DateTime.Today;
            //now
            var d2 = DateTime.Now;
            var d3 = new DateTime(2020, 7, 13, 10, 5, 18);

            //add one day
            d = d.AddDays(1);
            //add month
            d = d.AddMonths(1);


        }
    }
}
