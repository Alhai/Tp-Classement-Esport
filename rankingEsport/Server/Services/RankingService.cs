using rankingEsport.Server.Interfaces;
using rankingEsport.Server.Persistences;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace rankingEsport.Server.Services
{
    public class RankingService : IRanking
    {
        private readonly RankingPersistence RankingPersistence;

        public RankingService(RankingPersistence RankingPersistence)
        {
            this.RankingPersistence = RankingPersistence;
        }

        private int rank;
        public int Rank
        {
            get { return rank; }
            set { rank = value; OnPropertyChanged(); }
        }
        private string team;
        public string Team
        {
            get { return team; }
            set { team = value; OnPropertyChanged(); }
        }

        private int winrate;
        public int WinRate
        {
            get { return winrate; }
            set { winrate = value; OnPropertyChanged(); }
        }

        private int totalpoint;
        public int TotalPoint
        {
            get { return totalpoint; }
            set { totalpoint = value; OnPropertyChanged(); }
            }

        void IRanking.FilterDate()
        {
            throw new NotImplementedException();
            /*
             * classer en fonction de la date
             */
        }

        void IRanking.FilterGame()
        {
            throw new NotImplementedException(); //classer en fonction de résultat de jeu
        }

        void IRanking.FilterVictory()
        {
            throw new NotImplementedException(); // classer en fonction du nombre de victoire
        }

        void IRanking.RankingPlayers()
        {
            throw new NotImplementedException(); 
            // classer en fonction du rang du joueurs
        }

        void IRanking.RankingTeams()
        {
            throw new NotImplementedException(); // classer en fonction du rang de l'équipe
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
