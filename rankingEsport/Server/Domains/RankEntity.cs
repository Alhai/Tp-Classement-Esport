﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rankingEsport.Server.Domains
{
    public class RankEntity // création de la classe d'entité
    {
        public int Rank { get; set; } 
        public string?  Team { get; set; }
        public int WinRate { get; set; }
        public int TotalPoint { get; set; }
    }
}
