using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rankingEsport.Interface
{
     interface IGames
    {
        int ID { get; set; }
        DateTime Date { get; set; }
        string Name {  get; set; }
        Teams teams { get; set; }
        int Score { get; set; }
        string Statistiques { get; set; }

        void SaveStatisticGames();
        void SaveStatisticPlayers();
        void SaveStatisticteams();
        
       
    }
}
