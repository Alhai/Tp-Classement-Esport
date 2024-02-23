using rankingEsport.Domains;
using rankingEsport.Interfaces;
using rankingEsport.Models;
using rankingEsport.Persistances;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace rankingEsport.Services
{
    public class PlayerService : IPlayer
    {
        private readonly PlayerPersistence playerPersistence;

        //public PlayerService(PlayerPersistence playerPersistence)
        //{
        //    this.playerPersistence = playerPersistence;
        //}

        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; OnPropertyChanged(); }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }
        private string pseudo;
        public string Pseudo
        {
            get { return pseudo; }
            set { pseudo = value; OnPropertyChanged(); }
        }
        private string team;
        public string Team
        {
            get { return team; }
            set { team = value; OnPropertyChanged(); }
        }

        private int statistic;

        public PlayerService(PlayerPersistence playerPersistence)
        {
            this.playerPersistence = playerPersistence;
        }

        public int Statistic
        {
            get { return statistic; }
            set { statistic = value; OnPropertyChanged(); }
        }

        public void AddPlayer(PlayerModel newPlayer)
        {
               if (newPlayer == null)
    {
        throw new ArgumentNullException(nameof(newPlayer), "Le nouveau joueur ne peut pas être null.");
    }
            new PlayerEntity { Name = this.Name, ID = this.ID, Pseudo = this.Pseudo, Statistic = this.Statistic, Team = this.Team };

            playerPersistence.AddPlayer(newPlayer);
        }

        public void DeletePlayer(int playerId)
        {
            playerPersistence.DeletePlayer(playerId);
        }

        public void UpdatePlayer()
        {
            throw new NotImplementedException();
        }


        public string AccountHolderName { get; private set; }

        public void UpdatePlayer(PlayerModel updatedPlayer)
        {
            if (updatedPlayer == null || updatedPlayer.ID <= 0)
            {
                throw new ArgumentException("Le joueur mis à jour doit avoir un ID valide.", nameof(updatedPlayer));
            }

            var existingPlayer = playerPersistence.FindPlayerById(updatedPlayer.ID);
            if (existingPlayer == null)
            {
                throw new KeyNotFoundException($"Aucun joueur trouvé avec l'ID {updatedPlayer.ID}.");
            }

            // Mettez à jour les propriétés du joueur existant avec les nouvelles valeurs
            existingPlayer.Name = updatedPlayer.Name;
            existingPlayer.Pseudo = updatedPlayer.Pseudo;
            existingPlayer.Team = updatedPlayer.Team;
            existingPlayer.Statistic = updatedPlayer.Statistic;

            // Enregistrez les modifications dans la persistence
            //playerPersistence.Save();
        }

        public ICommand AddPlayerCommand { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void DeletePlayer()
        {
            throw new NotImplementedException();
        }
    }
}
