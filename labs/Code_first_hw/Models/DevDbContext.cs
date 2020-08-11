using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Code_first_hw.Models
{
    class DevDbContext : DbContext
    {
        //map class to table with db set
        public DbSet<Game> Games { get; set; }
        public DbSet<Developer> Developers { get; set; }


        //no start up cs so connect to database here
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source = (localdb)\\mssqllocaldb;Initial Catalog = CodeFirstGames;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Developer>().HasData(new Developer { DeveloperId = 1, DevName = "Naughty Dog", DevDescription = "Sony exclusives"});
            builder.Entity<Developer>().HasData(new Developer { DeveloperId = 2, DevName = "365", DevDescription = "Xbox exclusives" });
            builder.Entity<Developer>().HasData(new Developer { DeveloperId = 3, DevName = "Steam", DevDescription = "Steam exclusives" });

            builder.Entity<Game>().HasData(new Game { GameId = 1, GameName = "Crash", GameDescription = "Franchise on PS", DeveloperId = 1 });
            builder.Entity<Game>().HasData(new Game { GameId = 2, GameName = "Halo", GameDescription = "Franchise on XBOX", DeveloperId = 2 });
            builder.Entity<Game>().HasData(new Game { GameId = 3, GameName = "Valve", GameDescription = "Franchise on Steam", DeveloperId = 3 });


        }
    }
}
