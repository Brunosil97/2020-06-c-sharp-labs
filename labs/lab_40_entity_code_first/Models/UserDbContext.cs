using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab_40_entity_code_first.Models
{
    class UserDbContext : DbContext
    {
        //map class to table with db set
        public DbSet<User> Users { get; set; }

        //no start up cs so connect to database here
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlite("Data Source = UserDatabase.db");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().HasData(new User { UserId = 1, UserName = "some User", DateOFBirth = new DateTime(2020, 08, 10) });
            builder.Entity<User>().HasData(new User { UserId = 2, UserName = "another User", DateOFBirth = new DateTime(2010, 04, 6) });
            builder.Entity<User>().HasData(new User { UserId = 3, UserName = "a third User", DateOFBirth = new DateTime(2025, 12, 4) });


        }
    }
}
