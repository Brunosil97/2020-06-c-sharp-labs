﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MDNWalkthrough
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}},
                new Student {First="Claire", Last="O'Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
                new Student {First="Sven", Last="Mortensen", ID=113, Scores= new List<int> {88, 94, 65, 91}},
                new Student {First="Cesar", Last="Garcia", ID=114, Scores= new List<int> {97, 89, 85, 82}},
                new Student {First="Debra", Last="Garcia", ID=115, Scores= new List<int> {35, 72, 91, 70}},
                new Student {First="Fadi", Last="Fakhouri", ID=116, Scores= new List<int> {99, 86, 90, 94}},
                new Student {First="Hanying", Last="Feng", ID=117, Scores= new List<int> {93, 92, 80, 87}},
                new Student {First="Hugo", Last="Garcia", ID=118, Scores= new List<int> {92, 90, 83, 78}},
                new Student {First="Lance", Last="Tucker", ID=119, Scores= new List<int> {68, 79, 88, 92}},
                new Student {First="Terry", Last="Adams", ID=120, Scores= new List<int> {99, 82, 81, 79}},
                new Student {First="Eugene", Last="Zabokritski", ID=121, Scores= new List<int> {96, 85, 91, 60}},
                new Student {First="Michael", Last="Tucker", ID=122, Scores= new List<int> {94, 92, 91, 91}}
            };

            // Create the query.
            // The first line could also be written as "var studentQuery ="
            IEnumerable<Student> studentQuery =
                from student in students
                where student.Scores[0] > 90
                orderby student.Scores[0] descending
                select student;

            // Execute the query.
            // var could be used here also.
            Console.WriteLine("Query 1");
            foreach (Student student in studentQuery)
            {
                Console.WriteLine("{0}, {1} {2}", student.Last, student.First, student.Scores[0]);
            }

            // studentQuery2 is an IEnumerable<IGrouping<char, Student>>
            IEnumerable<IGrouping<char, Student>> studentQuery2 =
                from student in students
                group student by student.Last[0];

            //studentGroup is a IGrouping<char, Student>
            Console.WriteLine("Query 2");
            foreach (var studentGroup in studentQuery2)
            {
                Console.WriteLine(studentGroup.Key);
                foreach(Student student in studentGroup)
                {
                    Console.WriteLine("   {0}, {1}", student.Last, student.First);
                }    
            }

            var studentQuery3 =
                from student in students
                group student by student.Last[0];

            Console.WriteLine("Query 3");
            foreach (var groupOfStudents in studentQuery3)
            {
                Console.WriteLine(groupOfStudents.Key);
                foreach (var student in groupOfStudents)
                {
                    Console.WriteLine("   {0}, {1}",
                        student.Last, student.First);
                }
            }

            //Order groups by their key value
            var studentQuery4 =
                from student in students
                group student by student.Last[0] into studentGroup
                orderby studentGroup.Key
                select studentGroup;

            Console.WriteLine("Query 4");
            foreach (var groupOfStudents in studentQuery4)
            {
                Console.WriteLine(groupOfStudents.Key);
                foreach(var student in groupOfStudents)
                {
                    Console.WriteLine("    {0}, {1}", student.Last, student.First);
                }
            }

            // studentQuery5 is an IEnumerable<string>
            // This query returns those students whose
            // first test score was higher than their
            // average score.
            var studentQuery5 =
                from student in students
                let totalScore = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
                where totalScore / 4 < student.Scores[0]
                select student.Last + " " + student.First;

            Console.WriteLine("Query 5");
            foreach(string s in studentQuery5)
            {
                Console.WriteLine(s);
            }

            //method syntax
            var studentQuery6 =
                from student in students
                let totalScore = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
                select totalScore;

            double averageScore = studentQuery6.Average();
            Console.WriteLine("Query 6");
            Console.WriteLine("Class average score = {0}", averageScore);


            IEnumerable<string> studentQuery7 =
                from student in students
                where student.Last == "Garcia"
                select student.First;

            Console.WriteLine("Query 7");
            Console.WriteLine("The Garcias in the class are: ");
            foreach(string s in studentQuery7)
            {
                Console.WriteLine(s);
            }

            //get students with scores higher than average
            var studentQuery8 =
                from student in students
                let x = student.Scores[0] + student.Scores[1] +
                    student.Scores[2] + student.Scores[3]
                where x > averageScore
                select new { id = student.ID, score = x };

            Console.WriteLine("Query 8");
            foreach (var item in studentQuery8)
            {
                Console.WriteLine("Student ID: {0}, Score: {1}", item.id, item.score);
            }
        }
    }

}
