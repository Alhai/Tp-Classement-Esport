using rankingEsport.Domains;
using rankingEsport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rankingEsport.Interfaces
{
    interface IPlayer

    {
        void AddPlayer(PlayerModel player );
        void UpdatePlayer();
        void DeletePlayer();

    }
}
