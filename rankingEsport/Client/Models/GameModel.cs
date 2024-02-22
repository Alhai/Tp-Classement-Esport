using System;
using System.Collections.Generic;

namespace rankingEsport.Models
{
    public class GameModel
    {
        public int ID { get; set; } 
        public DateTime Date { get; set; }
        public string GameType { get; set; } 
        public List<string> Participants { get; set; } 
        public string Score { get; set; }
        public string GameStatistics { get; set; }

        public GameModel()
        {
            Participants = new List<string>(); 
        }
    }
}
