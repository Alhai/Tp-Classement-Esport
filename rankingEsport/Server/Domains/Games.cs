using System;

namespace rankingEsport.Domains
{
    public class GameModel
    {
        public int GameID { get; set; }
        public DateTime Date { get; set; }
        public string GameType { get; set; }
        public string TeamsPlayers { get; set; }
        public string Score { get; set; }
        public string GameStatistics { get; set; }

        public GameModel()
        {
        }

        public string FormattedDate => Date.ToString("d");
    }
}