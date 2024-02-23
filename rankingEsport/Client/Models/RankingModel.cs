using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rankingEsport.Client.Models
{
    public class RankingModel
    {
        public int Rank { get; set; }
        public required string Team { get; set; }
        public int WinRate { get; set; }
        public int TotalPoint { get; set; }
    }
}
