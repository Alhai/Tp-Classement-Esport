using rankingEsport.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace rankingEsport.Services
{
    public class GamesService : IGames
    {
        private int id;
        public int Id 
        {   get { return id; } 
            set { id = value; OnPropertyChanged(); } 
        }
        private DateTime date;
        public GamesService(DateTime date)
        {
            this.date = date;
        }
        public DateTime Date 
        {
            get { return date; }
            set { date = value; OnPropertyChanged(); }
        }

        private string gamename;
        public string GameName 
        {   get { return gamename; } 
            set { gamename = value; OnPropertyChanged(); } 
        }
        private int score;

        public int Score 
        {   get { return score; } 
            set { score = value; OnPropertyChanged(); } 
        }
        private string statistic;

        public string Statistic
        {
            get { return statistic; }
            set { statistic = value; OnPropertyChanged(); }
        }

        public void Result()
        {
            throw new NotImplementedException();
        }
        public void SaveResultGame()
        {
            throw new NotImplementedException();
        }
        public void SaveResultPlayers()
        {
            throw new NotImplementedException();
        }
        public void SaveResultTeams()
        {
            throw new NotImplementedException();
        }
        public void SoloGame()
        {
            throw new NotImplementedException();
        }
        public void MultiPlayerGame()
        {
            throw new NotImplementedException();
        }

        //public void SaveGame(Game game)
        //{
            
        //}

        //public void UpdateGame(Game game)
        //{

        //}

        public void DeleteGame(Guid gameId)
        {

        }
        public ICommand AddGameCommand { get; private set; }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

