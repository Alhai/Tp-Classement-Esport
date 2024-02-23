using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rankingEsport.Server.Interfaces
{
    interface IRanking //création de l'interface IRanking
    {
        void FilterGame(); // méthode de filtrage en fonction du jeu
        void FilterDate(); // méthode de filtrage en fonction de la date
        void FilterVictory(); // méthode de filtrage en fonction du nombre de victoire
        void AddRanking(); //méthode d'ajout d'un rang
    }
}
