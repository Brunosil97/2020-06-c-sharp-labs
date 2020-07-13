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

            //birthday
            var brunoBday = new DateTime(1997, 04, 18);
            var age = DateTime.Now - brunoBday;

            int age2 = (int)((age.Days) / 365.25);
            Console.WriteLine(age2);

            var date = DateTime.Now.ToString("dd-MM-yyyy");
            var date2 = brunoBday.ToString("yy/MM/dd");
            Console.WriteLine(date);
            Console.WriteLine(date2);

            //1 hour time span
            var timespan = new TimeSpan(1, 0, 0);
            //add the time right now
            var date3 = DateTime.Now + timespan;
            // add one tick to our date
            var tick = new TimeSpan(1);
            date3 = date3 + tick;

            //Suit theSuit = Suit.HEARTS;
            //int suit = (int)theSuit;
            //Console.WriteLine(suit);
            //theSuit = Suit.DIAMONDS;

            Suit theSuit = (Suit)2;
            Console.WriteLine(theSuit); //will print diamonds

            switch (theSuit)
            {
                case (Suit.HEARTS):
                    Console.WriteLine("Heart");
                    break;
                case (Suit.SPADES):
                    Console.WriteLine("Spade");
                    break;
                case (Suit.DIAMONDS):
                    Console.WriteLine("Diamond");
                    break;
                case (Suit.CLUBS):
                    Console.WriteLine("Club");
                    break;

            }
            Console.WriteLine($"Sunday as a Number is {(int)DayOfWeek.Sunday}");
        }

        public enum Suit
        {
            HEARTS, CLUBS, DIAMONDS, SPADES
        }

        public enum Days
        {
            Monday = 1, Tuesday, Wednesday, Thursday = 8, Friday, Saturday, Sunday
        }
    }
}
