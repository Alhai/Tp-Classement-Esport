using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rankingEsport.Interfaces;

namespace rankingEsport.Domains
{ 
    public class Player 
    {
        public int ID { get; set; }
        public required string Name { get; set; }
        public required string Pseudo { get; set; }
        public required Teams Team { get; set; }
        public required  string Statistics { get; set; }

       
    }

}
