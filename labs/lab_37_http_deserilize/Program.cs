using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Runtime.ConstrainedExecution;
using System.IO;

namespace premierLeagueApi
{
    public class Todo
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }

    }

    public class Area
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Competition
    {
        public int id { get; set; }
        public Area area { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string plan { get; set; }
        public DateTime lastUpdated { get; set; }
    }

    public class Season
    {
        public int id { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public int currentMatchday { get; set; }
        public object winner { get; set; }
    }

    public class Team
    {
        public int id { get; set; }
        public string name { get; set; }
        public string crestUrl { get; set; }

        public override string ToString()
        {
            return $"{name}";
        }
    }

    public class Table
    {
        public int position { get; set; }
        public Team team { get; set; }
        public int playedGames { get; set; }
        public int won { get; set; }
        public int draw { get; set; }
        public int lost { get; set; }
        public int points { get; set; }
        public int goalsFor { get; set; }
        public int goalsAgainst { get; set; }
        public int goalDifference { get; set; }

    }

    public class Standing
    {
        public string stage { get; set; }
        public string type { get; set; }
        public object group { get; set; }
        public List<Table> table { get; set; }
    }

    public class Root
    {
        public Filters filters { get; set; }
        public Competition competition { get; set; }
        public Season season { get; set; }
        public List<Standing> standings { get; set; }
    }

    public class Filters
    {

    }
    public class ApiRequests
    {
        static Uri todosUrl = new Uri("https://jsonplaceholder.typicode.com/todos");

       

        static List<Todo> todos = new List<Todo>();
        static List<Todo> todosAsync = new List<Todo>();

        static Uri premierLeagueUrl = new Uri("http://api.football-data.org/v2/competitions/2021/standings");

        public List<Team> premierLeagueTeams = new List<Team>();

        public Root premierLeague;
        static void Main(string[] args)
        {

        }

        public void GetTeams()
        {
            GetCompetition();
            foreach (var standing in premierLeague.standings)
            {
                if (standing.type == "TOTAL")
                {
                    foreach (var table in standing.table)
                    {
                        premierLeagueTeams.Add(table.team);
                    }
                }
            }
        }

        public void GetCompetition()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("X-Auth-Token", "04ffe7eb763b42f1805c7a2857c8238d");
                var response =  httpClient.GetStringAsync(premierLeagueUrl);
                var data = response.Result;
                

                premierLeague = JsonConvert.DeserializeObject<Root>(data);
            }
        }
        public static void GetTodos()
        {
            using (var httpClient = new HttpClient())
            {
                var httpResponse = httpClient.GetStringAsync(todosUrl);
                var data = httpResponse.Result;

                todos = JsonConvert.DeserializeObject<List<Todo>>(data);
            }
        }

        public static async void GetTodosAsync()
        {
            using(var httpClient = new HttpClient())
            {
                var data = await httpClient.GetStringAsync(todosUrl);
           
                todosAsync = JsonConvert.DeserializeObject<List<Todo>>(data);
            }
        }
    }
}
