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

        public PlayerViewModel(PlayerService playerService)
        {
            this.playerService = playerService;
            this.Players = new ObservableCollection<PlayerModel>();
            this.AddPlayerCommand = new RelayCommand(AddPlayer);

        }
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
