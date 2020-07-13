using System;

namespace lab_21_exceptions
{
    class Program
    {
        private static string[] _theBeatles = new string[] { "John", "Paul", "George", "Ringo" };


        static void Main(string[] args)
        {
            //AddBeatle(4, "Brian");
        }
        public static void AddBeatle(int pos, string name)
        {
            //Add a try and catch method
            try
            {
                _theBeatles[pos] = name;
            }
            catch(Exception e) // if there is an error you can catch it, and display 
            {
                Console.WriteLine("Sorry, no 5th Beatle allowed");
            }
            finally //
            {
                Console.WriteLine("Here comes the sun");
            }
        }

        
    }
}
