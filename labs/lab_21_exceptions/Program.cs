using System;

namespace lab_21_exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddBeatle(4, "Brian");
            //int x = 10;
            //int y = 0;
            //try { int output = x / y; } catch (Exception e) { Console.WriteLine("An exception has occured"); }
            //finally { Console.WriteLine("But life goes on"); }

            Beatles.AddBeatle(4, "Brian"); 

            //checked

            checked
            {
                int three = 3;
                int sum = int.MaxValue + three;
                Console.WriteLine(sum);
            }
        }


       
    }

    public class Beatles
    {
        //public static void AddBeatle(int pos, string name)
        //{
        //    //Add a try and catch method
        //    try
        //    {
        //        _theBeatles[pos] = name;
        //    }
        //    catch(Exception e) // if there is an error you can catch it, and display 
        //    {
        //        Console.WriteLine("Sorry, no 5th Beatle allowed");
        //        Console.WriteLine($"{e.ToString()}");
        //        Console.WriteLine($"{e.Message}");

        //    }
        //    finally //
        //    {
        //        Console.WriteLine("Here comes the sun");
        //    }
        //}

        private static string[] _theBeatles = new string[] { "John", "Paul", "George", "Ringo" };

        public static void AddBeatle(int pos, string name)
        {
            if (pos < 0 || pos >= _theBeatles.Length)
            {
                throw new ArgumentException($"The Beatles do not have a position {pos}");
            }
            _theBeatles[pos] = name;
        }
    }
}
