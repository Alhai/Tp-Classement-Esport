using rankingEsport.Domains;
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
    public class PlayerService : IPlayer
    {
        private int id;
        public int ID
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
            set { pseudo = value; OnPropertyChanged(); }
        }
        private string team;
        public string Team
        {
            get { return team; }
            set { team = value; OnPropertyChanged(); }
        }

        private int statistic;
        public int Statistic
        {
            get { return statistic; }
            set { statistic = value; OnPropertyChanged(); }
        }

        public void AddPlayer(object obj)
        {
            new PlayerEntity { Name = this.Name, ID = this.ID, Pseudo = this.Pseudo, Statistic = this.Statistic, Team = this.Team };
        }

        public void RemovePlayer()
        {
            throw new NotImplementedException();
        }

        public void UpdatePlayer()
        {
            throw new NotImplementedException();
        }

        public ICommand AddPlayerCommand { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
