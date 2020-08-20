using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace lab_48_todo_app.Models
{
    public class TodoDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<User> Users { get; set; }

        public TodoDbContext() { }

        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //relationships
            builder.Entity<User>()
                .HasMany(user => user.Todos)
                .WithOne(user => user.User);

            builder.Entity<User>()
                .Property(user => user.UserName)
                .IsRequired();
            //seed data

            builder.Entity<User>().HasData(
                new User { UserId = 1, UserName = "Bruno"},
                new User { UserId = 2, UserName = "Bryn" },
                new User { UserId = 3, UserName = "Alex" }
            );

            builder.Entity<Todo>().HasData(
                new Todo { TodoId = 1, ToDoName = "Washing Up", UserId = 1},
                new Todo { TodoId = 2, ToDoName = "Change Clothes", UserId = 2},
                new Todo { TodoId = 3, ToDoName = "Order Food", UserId = 3}
            );
        }
    }
}
