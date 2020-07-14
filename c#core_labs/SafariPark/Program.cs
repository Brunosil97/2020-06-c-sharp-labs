using System;
using System.Drawing;
using System.Net.Cache;

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

            //structs 
            var s1 = new Point3D() { x = 1, y = 2, z = 3 };

            Person john = new Person("John", "Jones") { Age = 20 };
            Point3D pt3d = new Point3D(5, 8, 2);

            DemoMethod(pt3d, john);
          
        }

        static void DemoMethod(Point3D pt, Person p)
        {
            pt.y = 1000;
            p.Age = 92;
        }
    }
}
