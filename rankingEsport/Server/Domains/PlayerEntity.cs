using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rankingEsport.Interfaces;

namespace rankingEsport.Domains
{ 
    public class PlayerEntity
    {
        public int ID { get; set; }
        public required string Name { get; set; }
        public required string Pseudo { get; set; }
        public required string Team { get; set; }
        public required  int Statistic { get; set; }   
    }

}
