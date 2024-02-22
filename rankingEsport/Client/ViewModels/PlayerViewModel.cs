using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;
using rankingEsport.Models;
using rankingEsport.Persistances;
using rankingEsport.Services;
using rankingEsport.ViewModels;


namespace rankingEsport.ViewModels
{
    public class PlayerViewModel : INotifyPropertyChanged
    {
        private readonly PlayerService playerService;

        public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<PlayerModel> Players { get; set; }

        public ICommand AddPlayerCommand { get; private set; }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged(); }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }

        private string pseudo;
        public string Pseudo
        {
            get { return pseudo; }
            set { Pseudo = value; OnPropertyChanged(); }
        }

        private string team;
        public string Team
        {
            get { return team; }
            set { team = value; OnPropertyChanged(); }
        }
        private string statistic;
        public string Statistic
        {
            get { return statistic; }
            set { statistic = value; OnPropertyChanged(); }
        }
        public List<string> Teams { get; set; } = new List<string>()
        {
            "Droïde de protocole",
            "Droïde astromécano",
        };


        public PlayerViewModel()
        {
            this.playerService = new PlayerService(new PlayerPersistence());
            this.Players = new ObservableCollection<PlayerModel>();
            this.AddPlayerCommand = new Command(AddPlayer);

        }
        //public PlayerViewModel(PlayerService playerService)
        //{
        //    this.playerService = playerService;
        //    this.Players = new ObservableCollection<PlayerModel>();
        //    this.AddPlayerCommand = new Command(AddPlayer);

        //}

        private void AddPlayer(object obj)
        {
            var player = new PlayerModel { Name = "Nom", Pseudo = "Pseudo", Team = "Team", Statistic = 0 };
            playerService.AddPlayer(player);
            Players.Add(player);
        }
    
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
