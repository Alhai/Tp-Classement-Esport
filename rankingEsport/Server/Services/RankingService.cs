using rankingEsport.Server.Domains;
using rankingEsport.Server.Interfaces;
using rankingEsport.Server.Persistences;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace rankingEsport.Server.Services
{
    public class RankingService : IRanking
    {
        private readonly RankingPersistence RankingPersistence;//Lien vers la persistence de Ranking

        public RankingService(RankingPersistence RankingPersistence)//injection d'une dépendance vers le service de persistance des classements dans la classe RankingService.
        {
            this.RankingPersistence = RankingPersistence;
        }

        private int rank;
        public int Rank //appel du type int Rank
        {
            get { return rank; }
            set { rank = value; OnPropertyChanged(); }
        }
        private string team;
        public string Team //appel du type string Team
        {
            get { return team; }
            set { team = value; OnPropertyChanged(); }
        }

        private int winrate;
        public int WinRate //appel du type int WinRate
        {
            get { return winrate; }
            set { winrate = value; OnPropertyChanged(); }
        }

        private int totalpoint;
        public int TotalPoint // appel du type int TotalPoint
        {
            get { return totalpoint; }
            set { totalpoint = value; OnPropertyChanged(); }
            }
        public void AddRanking() // méthode dd'ajout d'un rang avec ces différents paramètre
        {
            new RankEntity { Rank = this.rank , Team = this.team , WinRate = this.winrate , TotalPoint = this.totalpoint };
        }
        void IRanking.FilterDate()
        {
            throw new NotImplementedException();
        }

        void IRanking.FilterGame()
        {
            throw new NotImplementedException(); 
           
        }

        void IRanking.FilterVictory()
        {
            throw new NotImplementedException();
        }
        public ICommand AddNewRanking { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
