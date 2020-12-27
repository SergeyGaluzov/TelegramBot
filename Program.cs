using System;
using System.Web.Mvc;

namespace TelegramBot
{
    public class GameParameters
    {
        public string Topic {get; set; }
        public string Difficulty { get; set; }
        public int QuestionsNumber { get; set; }
    }
    
    [Route("game/millionaire")]
    public class MillionereController : Controller
    {
        [HttpGet]
        public GameParameters Get(string topic, string difficulty, int questionsNumber)
        {
            var gameParams = new GameParameters();
            gameParams.Topic = topic;
            gameParams.Difficulty = difficulty;
            gameParams.QuestionsNumber = questionsNumber;
            return gameParams;
        }   
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}