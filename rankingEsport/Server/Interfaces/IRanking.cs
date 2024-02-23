using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rankingEsport.Server.Interfaces
{
    internal interface IRanking
    {
        void RankingPlayers();

        void RankingTeams();
        void FilterGame();
        void FilterDate();
        void FilterVictory();
        void AddRanking();
    }
}
