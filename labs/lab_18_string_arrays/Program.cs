using System;
using System.Collections.Generic;
using System.Text;

namespace lab_18_string_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] bruno = new char[5];

            bruno[0] = 'B';
            bruno[1] = 'r';
            bruno[2] = 'u';
            bruno[3] = 'n';
            bruno[4] = 'o';
            Console.WriteLine(bruno);

            char[] sparta = { 's', 'p', 'a', 'r', 't', 'a' };
            Console.WriteLine(sparta);

            int[] newArray = { 2, 3, 4, 5, 6 };
            var result = Array.ArraySum(newArray);
            Console.WriteLine(result);


            //int[,] grid2d = new int[2, 4]; //two dimensial
            //int[,,,] gird4d = new int[3, 4, 20, 30]; //four dimensial

            int[,] grid2d = { { 4, 7, 8, 9 },{ 6, 1, 7,10 } };
            int[,,] grid3d = { { { 4, 7, 8, 9 }, { 6, 1, 7, 10 }, { 4, 4, 4, 4 } } };

            //4  6 
            //7  1
            //8  7 
            //9  10 -- connections for grid2d, how its visualised

            int val = grid2d[0, 1]; // 0 refers to the column, and the 1 refers to the row
            int value = grid3d[0, 1, 0]; //returns 6 
            Console.WriteLine(val);
            Console.WriteLine(value);

            //jagged arrays
            string[][] animalGrid = new string[2][]; //creating an array that takes two arrays
            animalGrid[0] = new string[4]; //at index zero we add an array that takes 4 values
            animalGrid[1] = new string[2]; //at index one we add an array that takes 2 values

            animalGrid[0][0] = "Turkey";

            //intialize and declare jagged array
            string[][] animalGrid2 = new string[][]
            {
                new string[] {"llama", "puma", "horse", "kitten"},
                new string[] {"haddock", "tuna"}
            };

            var animal = animalGrid2[0][1];
            Console.WriteLine(animal);

            //Lists
            //declare with List and the type the values will be
            List<string> names = new List<string> (); //the type can chane, can pass in a object, if instanciated from Person, itll be person
            names.Add("Bruno");
            names.Add("Nish");
            //List<string> names = new List<string>{"Bruno", "Leo"}; //can add like so as well
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            //

            string myName = "Bruno Silva";
            Console.WriteLine(myName[1]); //gets r

            var allCars = myName.ToCharArray();
            var initials = myName.ToCharArray(1, 3); //starts at index 1 and ends at index 3
            Console.WriteLine(initials);
            Console.WriteLine(myName[1]); //gets r

            string firstName = "Bruno";
            string lastName = "Silva";
            int age = 23;

            var string1 = firstName + " " + lastName + " Age: " + age;
            var string2 = $"{firstName} {lastName} Age: {age}";
            Console.WriteLine(string1);
            Console.WriteLine(string2);

            string input = "33";
            int input2 = Int32.Parse(input);
            int sum = 1 + input2;
            Console.WriteLine(sum);
            //casting is telling that the object its something else without changing it. 
            //Parsing is taking one type and changing it to a different type 

            bool success = Int32.TryParse(input, out int input3); //will show true that it can parse
            Console.WriteLine($"{success} & {input3}"); //shows true and 33

            //String Builder
            StringBuilder sb = new StringBuilder("Hello");
            sb.Append("Hello Engineerng 66\nEspicially Nish");
        }
    }
        public class Array
        {
           public static int ArraySum(int[] practiceArray)
           {
                int arraySum = practiceArray[0] + practiceArray[1] + practiceArray[2];
                return arraySum;
           }
        }
    
}
