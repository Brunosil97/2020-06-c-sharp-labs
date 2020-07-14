using System;

namespace SafariPark
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating two objects from the Person class
            Person bruno = new Person("Bruno", "Silva");
            bruno.Age = 23;
            Console.WriteLine($"Bruno is {bruno.Age}");
            //Console.WriteLine(bruno.GetFullName());

            //Person nish = new Person("Nish", "French");
            //Console.WriteLine(bruno.GetFullName

            //overloading constructor instance
            //Person luis = new Person("Luis", "Wolton", 23);
            //Console.WriteLine(luis.Age);
        }

    }
}
