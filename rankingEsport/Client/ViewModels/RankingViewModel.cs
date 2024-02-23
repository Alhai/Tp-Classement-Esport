using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using rankingEsport.Client.Models;
using rankingEsport.Server.Domains;
using rankingEsport.Server.Persistences;
using rankingEsport.Server.Services;

namespace rankingEsport.Client.ViewModels
{
    public class RankingViewModel:INotifyPropertyChanged // classe RankingViewModel qui implémente l'interface INotifyPropertyChanged
    {
        private readonly RankingService rankingService; 

        public event PropertyChangedEventHandler? PropertyChanged;// evenement PropertyChangedEventHandler

        public ObservableCollection<RankingModel> Rankings { get; private set; } //ajout d'un observable

        public ICommand AddRankingCommand { get; private set; } //ajout de l'interace ICommand
        
        private int rank;
        public int Rank //initialisation du type int Rank
        {
            get { return rank; }
            set { rank = value; OnPropertyChanged(); }
        }
        private string team; 
        public string Team //initialisation du type string Team
        {
            get { return team; }
            set { team = value; OnPropertyChanged(); }
        }

        private int winrate;
        public int WinRate //initialisation du type int WinRate
        {
            get { return winrate; }
            set { winrate = value; OnPropertyChanged(); }
        }

        private int totalpoint;
        public int TotalPoint //initialisation du type int TotalPoint
        {
            get { return totalpoint; }
            set { totalpoint = value; OnPropertyChanged(); }
        }
        public RankingViewModel()
        {
            this.rankingService = new RankingService(new RankingPersistence());
            this.Rankings = new ObservableCollection<RankingModel>();
            this.AddRankingCommand = new Command(AddRanking);
        }
        public List<int> RanksList { get; set; } = new List<int>() // création d'une liste de rang de 1 à 6
        {
            1, 2, 3,
            4, 5, 6
        };

        public List<int> VictoryList { get; set; } = new List<int>() // création d'une liste de nombre de victoire
        {
            1,2, 3, 4, 5, 6
        };
        public void AddRanking() // implémentation de la méthode AddRanking de l'interface IRanking
        {
             new RankEntity { Rank = this.rank, Team = this.team, WinRate = this.winrate, TotalPoint = this.totalpoint }; // appel de tous les paramêtre de la class Rank
        }
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
