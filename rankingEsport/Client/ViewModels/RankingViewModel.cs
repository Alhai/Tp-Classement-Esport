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
using rankingEsport.Client.Models;
using rankingEsport.Models;
using rankingEsport.Persistances;
using rankingEsport.Server.Persistences;
using rankingEsport.Server.Services;
using rankingEsport.Services;
using rankingEsport.ViewModels;

namespace rankingEsport.Client.ViewModels
{
    public class RankingViewModel:INotifyPropertyChanged
    {
        private readonly RankingService rankingService;

        public event PropertyChangedEventHandler? PropertyChanged;
        
        public ObservableCollection<RankingModel> Rankings { get; private set; }
        
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
        public RankingViewModel()
        {
            this.rankingService = new RankingService(new RankingPersistence());
            this.Rankings = new ObservableCollection<RankingModel>();
        }
        public List<int> Ranks { get; set; } = new List<int>()
        {
            1, 2, 3,
            4, 5, 6
        };
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
