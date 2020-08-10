using lab_40_entity_code_first.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace lab_40_entity_code_first
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();

            using(var db = new UserDbContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                users = db.Users.ToList();
                users.ForEach(user => Console.WriteLine($"Name: {user.UserName} DOB: {user.DateOFBirth}"));
                //add an item
               

                //db.Users.Add(user);
                //db.SaveChanges();
            }
        }
    }
}
