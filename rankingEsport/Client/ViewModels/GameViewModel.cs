using rankingEsport.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace rankingEsport.Client.ViewModels
{
    public class GameViewModel : INotifyPropertyChanged
    {
        private int gameID;
        public int GameID
        {
            get { return gameID; }
            set { gameID = value; OnPropertyChanged(); }
        }

        private DateTime gameDate;
        public DateTime GameDate
        {
            get { return gameDate; }
            set { gameDate = value; OnPropertyChanged(); }
        }

        private string selectedGame;
        public string SelectedGame
        {
            get { return selectedGame; }
            set { selectedGame = value; OnPropertyChanged(); }
        }

        private string teamsPlayers;
        public string TeamsPlayers
        {
            get { return teamsPlayers; }
            set { teamsPlayers = value; OnPropertyChanged(); }
        }

        private string score;
        public string Score
        {
            get { return score; }
            set { score = value; OnPropertyChanged(); }
        }

        private string gameStatistics;
        public string GameStatistics
        {
            get { return gameStatistics; }
            set { gameStatistics = value; OnPropertyChanged(); }
        }

        // List of games for the picker
        public List<string> Games { get; set; } = new List<string>()
        {
            "Basketball",
            "Football",
            "Handball",
            "Baseball"
        };

        // ObservableCollection of GameModel instances
        public ObservableCollection<GameModel> GamesList { get; set; } = new ObservableCollection<GameModel>();

        public ICommand SaveGameCommand { get; private set; }
        public ICommand EditGameCommand { get; private set; }
        public ICommand DeleteGameCommand { get; private set; }

        public GameViewModel()
        {
            SaveGameCommand = new Command(SaveGame);
            EditGameCommand = new Command(EditGame);
            DeleteGameCommand = new Command(DeleteGame);

            // Add a sample game to the collection
            GamesList.Add(new GameModel
            {
                ID = 1,
                GameType = "Basketball",
                Date = DateTime.Now,
                // Initialize other properties if necessary
            });
        }

        private void SaveGame(object obj)
        {
            // Implementation of saving game data
        }

        private void EditGame(object obj)
        {
            // Implementation of editing game data
        }

        private void DeleteGame(object obj)
        {
            // Implementation of deleting game data
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
