using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rankingEsport.Interfaces
{
     interface IGames
    {
        void Result();
        void SaveResultGame();
        void SaveResultPlayers();
        void SaveResultTeams();
        void SoloGame();
        void MultiPlayerGame();

    }
}
