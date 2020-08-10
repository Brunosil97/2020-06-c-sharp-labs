using lab_40_entity_code_first.Models;
using Microsoft.EntityFrameworkCore;
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
            List<Category> categories = new List<Category>();

            using(var db = new UserDbContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                users = db.Users.ToList();
                categories = db.Categories.ToList();
                
                //add an item

                //var user = new User()
                //{
                //    UserName = "manual added User",
                //    DateOFBirth = new DateTime(2010, 4, 3)
                //};

                //db.Users.Add(user);
                //db.SaveChanges();

                users = null;
                users = db.Users.Include("Category").ToList();

                users.ForEach(user => Console.WriteLine($"Name: {user.UserName} DOB: {user.DateOFBirth} Category: {user.Category.CategoryName}"));

                categories.ForEach(category => Console.WriteLine($"Name: {category.CategoryName}"));
            }
        }
    }
}
