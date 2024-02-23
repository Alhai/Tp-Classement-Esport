using System;
using rankingEsport.Models;
using System.Linq;
using rankingEsport.Domains;

namespace rankingEsport.Persistances
{
	public class PlayerPersistence
	{

        public PlayerPersistence()
		{

		}
        private readonly List<PlayerModel> players = new List<PlayerModel>();
        private int lastId = 0;

        public void AddPlayer(PlayerModel player)
        {
            lastId++; 
            player.ID = lastId; 
            players.Add(player); 
        }

        public PlayerModel FindPlayerById(int id)
        {
            return players.FirstOrDefault(player => player.ID == id);
        }

        public void DeletePlayer(int playerId)
        {
            var playerToRemove = players.FirstOrDefault(p => p.ID == playerId);
            if (playerToRemove != null)
            {
                players.Remove(playerToRemove);
            }
        }

    }
}

