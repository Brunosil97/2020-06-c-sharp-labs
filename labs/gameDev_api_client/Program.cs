using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using gameDev_api_client.Models;
using Newtonsoft.Json;

namespace gameDev_api_client
{
    class Program
    {
        static List<Games> games = new List<Games>();
        static Games game = new Games();

        static Uri gamesUrl = new Uri("https://localhost:44300/api/Games");

        static List<Developer> developers = new List<Developer>();
        static Developer developer = new Developer();

        static Uri devsUrl = new Uri("https://localhost:44300/api/Developers");
        static void Main(string[] args)
        {
            //var newGame = new Games()
            //{
            //    GameName = "Crash Bandicoot",
            //    GameDescription = "Naughty dog exclusive",
            //    DevId = 1
            //};

            Thread.Sleep(8000);
            //GetOneGame(1);
            //Post
            //AddANewGame(newGame);

            //Delete
            //DeleteGame(2);

            //Update
            //Thread.Sleep(2000);

            //game.GameDescription = "PS1 Sony Exclusive";
            //UpdateGame(game);

            //Thread.Sleep(2000);
            ////Read
            //GetAllGames();
            //Thread.Sleep(2000);

            //foreach(var game in games)
            //{
            //    Console.WriteLine($"Developer name is: {game.GameName}");
            //}
            GetAllDevelopers().Wait();

            foreach(var developer in developers)
            {
                Console.WriteLine($"Developer name is: {developer.DevName}");
            }

            GetOneDeveloper(1).Wait();
            Console.WriteLine($"This developer name is {developer.DevName}");



        }

        static async Task<List<Developer>> GetAllDevelopers()
        {
            using(var httpClient = new HttpClient())
            {
                var data = await httpClient.GetStringAsync(devsUrl);

                developers = JsonConvert.DeserializeObject<List<Developer>>(data);
                return developers;
            }
        }

        static async Task<Developer> GetOneDeveloper(int devId)
        {
            using(var httpClient = new HttpClient())
            {
                var data = await httpClient.GetStringAsync($"{devsUrl}/{devId}");

                developer = JsonConvert.DeserializeObject<Developer>(data);
                return developer;
            }
        }
        static async void GetAllGames()
        {
            using(var httpClient = new HttpClient())
            {
                var data = await httpClient.GetStringAsync(gamesUrl);

                games = JsonConvert.DeserializeObject<List<Games>>(data);
            }
        }

        static async void GetOneGame(int gameId)
        {
            using(var httpClient = new HttpClient())
            {
                var data = await httpClient.GetStringAsync($"{gamesUrl}/{gameId}");
                game = JsonConvert.DeserializeObject<Games>(data);
            }
        }


        static async void UpdateGame(Games game)
        {
            string newGameJson = JsonConvert.SerializeObject(game);
            var httpContent = new StringContent(newGameJson);

            httpContent.Headers.ContentType.MediaType = "application/json";
            httpContent.Headers.ContentType.CharSet = "UTF-8";

            using(var httpClient = new HttpClient())
            {
                var httpResponse = await httpClient.PutAsync($"{gamesUrl}/{game.GameId}", httpContent);
                Console.WriteLine($"Update was successful: {httpResponse.IsSuccessStatusCode}");
            }
        }

        static async void DeleteGame(int gameId)
        {
            using (var httpClient = new HttpClient())
            {
                var data = await httpClient.DeleteAsync($"{gamesUrl}/{gameId}");
                Console.WriteLine($"Delete was successful: {data.IsSuccessStatusCode}");
            }
        }


        static async void AddANewGame(Games game)
        {
            string newGameJson = JsonConvert.SerializeObject(game);
            var httpContent = new StringContent(newGameJson);

            httpContent.Headers.ContentType.MediaType = "application/json";
            httpContent.Headers.ContentType.CharSet = "UTF-8";

            using(var httpClient = new HttpClient())
            {
                var httpResponse = await httpClient.PostAsync(gamesUrl, httpContent);
                Console.WriteLine($"Success status was: {httpResponse.IsSuccessStatusCode}");
            }
        }

        static bool GameExists(int gameId)
        {
            var gameExists = games.Where(g => g.GameId == gameId).FirstOrDefault();

            if (gameExists == null)
            {
                return false;
            }
            else
            {
                Console.WriteLine("Customer already exists");
                return true;
            }
        }
    }
}
