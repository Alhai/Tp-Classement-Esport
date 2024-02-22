using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rankingEsport.Domains
{
   

    public class Games
    {
        public int ID { get; set; }
        public required DateTime Date { get; set; }

        public required string NameGame { get; set; }

        public required Teams team {  get; set; }

        public required int Score { get; set; }

        public required string Statistics { get; set; }
    }

   
}