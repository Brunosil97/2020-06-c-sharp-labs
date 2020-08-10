using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using gameDev_api_client.Models;
using Newtonsoft.Json;

namespace gameDev_api_client
{
    public class Program
    {
        public List<Games> games = new List<Games>();
        public Games game = new Games();

        public Uri gamesUrl = new Uri("https://localhost:44300/api/Games");

        public List<Developer> developers = new List<Developer>();
        public Developer developer = new Developer();

        public Uri devsUrl = new Uri("https://localhost:44300/api/Developers");

        public Developer SelectedDeveloper { get; set; }
        public Games SelectedGame { get; set; }
        public Developer DropDownDev { get; set; }
        static void Main(string[] args)
        {
        }

        public void GetAllDevelopers()
        {
            using(var httpClient = new HttpClient())
            {
                var data =  httpClient.GetStringAsync(devsUrl);

                developers = JsonConvert.DeserializeObject<List<Developer>>(data.Result);
            }
        }

        public async Task<Developer> GetOneDeveloper(int devId)
        {
            using(var httpClient = new HttpClient())
            {
                var data = await httpClient.GetStringAsync($"{devsUrl}/{devId}");

                developer = JsonConvert.DeserializeObject<Developer>(data);
                return developer;
            }
        }

        public void AddNewDeveloper(string name, string description)
        {
            Developer developer = new Developer()
            {
                DevName = name,
                DevDescription = description
            };

            string newDevJson = JsonConvert.SerializeObject(developer);
            var httpContent = new StringContent(newDevJson);

            httpContent.Headers.ContentType.MediaType = "application/json";
            httpContent.Headers.ContentType.CharSet = "UTF-8";

            using(var httpClient = new HttpClient())
            {
                var httpResponse = httpClient.PostAsync(devsUrl, httpContent);
                Console.WriteLine($"successful? {httpResponse.Result.IsSuccessStatusCode}");
            }
        }

        public void UpdateDeveloper(Developer developer, string name, string description)
        {
            developer.DevName = name;
            developer.DevDescription = description;

            string newGameJson = JsonConvert.SerializeObject(developer);
            var httpContent = new StringContent(newGameJson);

            httpContent.Headers.ContentType.MediaType = "application/json";
            httpContent.Headers.ContentType.CharSet = "UTF-8";

            using (var httpClient = new HttpClient())
            {
                var httpResponse = httpClient.PutAsync($"{devsUrl}/{developer.DevId}", httpContent);
                Console.WriteLine($"Update was successful: {httpResponse.Result.IsSuccessStatusCode}");
            }
        }
        public void DeleteDeveloper(int devId)
        {
            using(var httpClient = new HttpClient())
            {
                var data = httpClient.DeleteAsync($"{devsUrl}/{devId}");
                Console.WriteLine($"Delete was successful: {data.Result.IsSuccessStatusCode}");
            }
        }
        public void GetAllGames()
        {
            using(var httpClient = new HttpClient())
            {
                var data = httpClient.GetStringAsync(gamesUrl);

                games = JsonConvert.DeserializeObject<List<Games>>(data.Result);
            }
        }

        public async void GetOneGame(int gameId)
        {
            using(var httpClient = new HttpClient())
            {
                var data = await httpClient.GetStringAsync($"{gamesUrl}/{gameId}");
                game = JsonConvert.DeserializeObject<Games>(data);
            }
        }


        public async void UpdateGame(Games game, string name, string description)
        {
            game.GameName = name;
            game.GameDescription = description;

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

        public async void DeleteGame(int gameId)
        {
            using (var httpClient = new HttpClient())
            {
                var data = await httpClient.DeleteAsync($"{gamesUrl}/{gameId}");
                Console.WriteLine($"Delete was successful: {data.IsSuccessStatusCode}");
            }
        }


        public async void AddANewGame(Games game)
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

        public void setSelectedDeveloper(Object selectedDev)
        {
            SelectedDeveloper = (Developer)selectedDev;
        }

        public void SetDropDownDev(Object selectedDev)
        {
            DropDownDev = (Developer)selectedDev;
        }

        public void SetSelectedGame(Object selectedGame)
        {
            SelectedGame = (Games)selectedGame;
        }
    }
}
