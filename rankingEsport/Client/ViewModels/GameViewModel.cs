using rankingEsport.Domains;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using rankingEsport.Services;
using rankingEsport.Interfaces;

namespace rankingEsport.Client.ViewModels
{
    public class GameViewModel : INotifyPropertyChanged
    {
        private readonly IGames _gameService;
        private int gameID;
        public int GameID
        {
            get { return gameID; }
            set { gameID = value; OnPropertyChanged(); }
        }

        private DateTime gameDate = DateTime.Now;
        public DateTime GameDate
        {
            get { return gameDate; }
            set
            {
                gameDate = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FormattedDate));
            }
        }

        public string FormattedDate => GameDate.ToString("d");

        private string gameType;
        public string GameType
        {
            get { return gameType; }
            set { gameType = value; OnPropertyChanged(); }
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

        public List<string> Games { get; set; } = new List<string>()
        {
            "Basketball",
            "Football",
            "Handball",
            "Baseball"
        };

        public ObservableCollection<GameModel> GamesList { get; set; }

        public ICommand SaveGameCommand { get; private set; }
        public ICommand EditCommand { get; private set; }
        public ICommand DeleteCommand { get; private set; }

        public GameViewModel() : this(new GameService())
        {
        }
        public GameViewModel(IGames gameService)
        {
            _gameService = gameService ?? throw new ArgumentNullException(nameof(gameService));
            GamesList = new ObservableCollection<GameModel>(_gameService.GetGames());

            SaveGameCommand = new Command(SaveGame);
            EditCommand = new Command(EditGame);
            DeleteCommand = new Command(DeleteGame);
        }


        private void SaveGame()
        {
            var newGame = new GameModel
            {
                GameID = gameID,
                GameType = gameType,
                Date = gameDate,
                TeamsPlayers = teamsPlayers,
                Score = score,
                GameStatistics = gameStatistics,
            };

            _gameService.AddGame(newGame); 
            GamesList.Add(newGame); 
            ResetFormData();
        }


        private void EditGame(object gameToEdit)
        {
            if (gameToEdit is GameModel game)
            {
                _gameService.UpdateGame(game);
            }
        }

        private void DeleteGame(object gameModel)
        {
            if (gameModel is GameModel game)
            {
                _gameService.DeleteGame(game.GameID);
            }
        }

        private void ResetFormData()
        {
            GameID = 0;
            GameDate = DateTime.Now;
            GameType = null;
            TeamsPlayers = string.Empty;
            Score = string.Empty;
            GameStatistics = string.Empty;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
