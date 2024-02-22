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
        void AddPlayer(object obj);
        void RemovePlayer();
        void UpdatePlayer();

    }
}
