using Code_first_hw.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Code_first_hw
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Game> games = new List<Game>();
            List<Developer> developers = new List<Developer>();

            using (var db = new DevDbContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                games = db.Games.ToList();
                developers = db.Developers.ToList();

                games = null;
                games = db.Games.Include("Developer").ToList();

                games.ForEach(game => Console.WriteLine($"Name: {game.GameName} Description: {game.GameDescription} Dev: {game.Developer.DevName}"));

                developers.ForEach(dev => Console.WriteLine($"Name: {dev.DevName}"));

            }
        }
    }
}
