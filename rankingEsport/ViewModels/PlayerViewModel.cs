using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using rankingEsport.ViewModels;


namespace rankingEsport.ViewModels
{
    public class PlayerViewModel : INotifyPropertyChanged
    {
        private string id;
        public string ID
        { 
            get { return id; }
            set { id = value; OnPropertyChanged(); }
        }
        private string name;
        public string Name
        { get { return name; } 
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

        public List<string> Teams { get; set; } = new List<string>()
        {
            "barcelona",
            "psg",
            "liverpool",
            "leipzig"
        };
    };
    public PlayerViewModel()
    {
        AddPlayerCommand = new Command(AddPlayer);
    }
    public ICommand AddPlayerCommand { get; private set; }

    public void AddPlayer (PlayerViewModel player, object Players)
    {
        Players.Add(new PlayerModel { Name = this.Name, ID = this.ID, Pseudo = this.Pseudo, Statistic = this.Statistic, Team = this.Team });      
    }
    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
