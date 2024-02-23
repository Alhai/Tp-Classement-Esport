using System.Collections.ObjectModel;
using System.Linq;
using rankingEsport.Interfaces;
using rankingEsport.Domains;


namespace rankingEsport.Services
{
    public class GameService : IGames
    {
        public ObservableCollection<GameModel> GamesList { get; set; } = new ObservableCollection<GameModel>();

        public GameService()
        {
            // Ajoute un jeu de démo
            GamesList.Add(new GameModel
            {
                GameID = 1,
                GameType = "Basketball",
                Date = DateTime.Now,
                TeamsPlayers = "zahra",
                Score = "10",
                GameStatistics = "bien",
            });
        }

        // Méthode pour ajouter un jeu à la liste
        public void AddGame(GameModel game)
        {
            GamesList.Add(game);
        }

        // Méthode pour supprimer un jeu de la liste
        public void DeleteGame(int gameId)
        {
            var game = GamesList.FirstOrDefault(g => g.GameID == gameId);
            if (game != null)
                GamesList.Remove(game);
        }

        // Méthode pour récupérer la liste des jeux
        public ObservableCollection<GameModel> GetGames()
        {
            return GamesList;
        }

        // Méthode pour mettre à jour les info
        public void UpdateGame(GameModel game)
        {
            var existingGame = GamesList.FirstOrDefault(g => g.GameID == game.GameID);
            if (existingGame != null)
            {
                existingGame.GameType = game.GameType;
                existingGame.Date = game.Date;
                existingGame.TeamsPlayers = game.TeamsPlayers;
                existingGame.Score = game.Score;
                existingGame.GameStatistics = game.GameStatistics;
            }
        }
    }
}