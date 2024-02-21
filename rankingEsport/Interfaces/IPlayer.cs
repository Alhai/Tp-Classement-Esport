using rankingEsport.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rankingEsport.Interfaces
{
    interface IPlayer

    {
        int ID { get; set; }
        string Name { get; set; }
        string Pseudo { get; set; }
        Teams Team { get; set; }
        string Statistics { get; set; }
    }
}
