using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace rankingEsport.Models
{
    public class GameModel : INotifyPropertyChanged
    {
        public int GameID { get; set; } 
        public DateTime Date { get; set; }
        public string GameType { get; set; } 
        public List<string> Participants { get; set; } 
        public string Score { get; set; }
        public string GameStatistics { get; set; }
        public string TeamsPlayers { get; internal set; }   


        public GameModel()
        {
            Participants = new List<string>(); 
        }
        public string FormattedDate => Date.ToString("d");

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
