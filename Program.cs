using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace TelegramBot
{
    public class Question   
    {
        public List<string> Options; 
        public string QuestionText; 
        public int AnswerId; 
    }

    public class Game    
    {
        public List<string> Topics; 
        public int Difficulty; 
        public List<Question> Questions; 
    }

    public class GameRoot   
    {
        public string GameId; 
        public Game Game; 
    }
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://35.233.79.129/game/millionaire?topic=science&difficulty=EASY&questions=2");
            var responseBody = await response.Content.ReadAsStringAsync();
            var obj = JsonConvert.DeserializeObject<GameRoot>(responseBody);
        }
    }
}