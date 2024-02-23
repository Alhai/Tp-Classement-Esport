using System.Collections.ObjectModel;
using rankingEsport.Domains;

namespace rankingEsport.Interfaces
{
    public interface IGames 
    {
        ObservableCollection<GameModel> GetGames();
        void AddGame(GameModel game);
        void UpdateGame(GameModel game);
        void DeleteGame(int gameId);
    }
}

