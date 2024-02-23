using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rankingEsport.Client.Models
{
    public class RankingModel // création du model de classe Rank
    {
        public int Rank { get; set; } // entier Rank
        public required string Team { get; set; } //chaine de caractère Team
        public int WinRate { get; set; } // entier WinRate
        public int TotalPoint { get; set; } // entier TotalPoint
    }
}
