using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Cache;

namespace SafariPark
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating two objects from the Person class
            //Person bruno = new Person("Bruno", "Silva");
            //bruno.Age = 23;
            //Console.WriteLine($"Bruno is {bruno.Age}");
            ////Console.WriteLine(bruno.GetFullName());

            ////Person nish = new Person("Nish", "French");
            ////Console.WriteLine(bruno.GetFullName

            ////overloading constructor instance
            ////Person luis = new Person("Luis", "Wolton", 23);
            ////Console.WriteLine(luis.Age);

            ////structs 
            //var s1 = new Point3D() { x = 1, y = 2, z = 3 };

            //Person john = new Person("John", "Jones") { Age = 20 };
            //Point3D pt3d = new Point3D(5, 8, 2);

            //DemoMethod(pt3d, john);

            //Hunter bruno = new Hunter("Bruno", "Silva", "nikon") { Age = 23 };
            //Console.WriteLine(bruno.Age);
            //Console.WriteLine(bruno.Shoot());

            //default inherited construction
            //Hunter bruno2 = new Hunter();
            //Console.WriteLine(bruno2.Age);
            //Console.WriteLine(bruno2.Shoot());


            //create a list of objects
            //Person bruno1 = new Person("Bruno", "Silva") { Age = 23 };
            //Hunter nish = new Hunter("Nish", "French", "nikon") ;
            //MonsterHunter luis = new MonsterHunter("Luis", "Wolton", "nikon", "fists");

            //var safariList = new List<object>();
            //safariList.Add(bruno1);
            //safariList.Add(nish);
            //safariList.Add(luis);

            //foreach(var obj in safariList)
            //{
            //    Console.WriteLine(obj.ToString());
            //}

            Airplane air = new Airplane(200, 100, "JetRUs", 0) { NumPassengers = 150 };
            air.Ascend(500);
            Console.WriteLine(air.Move(3));
            Console.WriteLine(air);
            air.Descend(200);
            Console.WriteLine(air.Move());
            air.Move();
            Console.WriteLine(air);

        }

        static void DemoMethod(Point3D pt, Person p)
        {
            pt.y = 1000;
            p.Age = 92;
        }
    }
}
