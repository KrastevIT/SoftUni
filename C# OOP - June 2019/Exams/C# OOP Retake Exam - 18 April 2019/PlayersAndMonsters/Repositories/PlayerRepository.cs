using PlayersAndMonsters.Models.Players.Contracts;
using PlayersAndMonsters.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayersAndMonsters.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private IList<IPlayer> players;
        public PlayerRepository()
        {
            this.players = new List<IPlayer>();
        }
        public int Count => this.players.Count;

        public IReadOnlyCollection<IPlayer> Players => this.players.ToList();

        public void Add(IPlayer player)
        {
            if (player == null)
            {
                throw new ArgumentException("Player cannot be null");
            }

            if (players.Any(x => x.Username == player.Username))
            {
                throw new ArgumentException($"Player {player.Username} already exists!");
            }

            players.Add(player);
        }

        public IPlayer Find(string username)
        {
            var player = players.FirstOrDefault(x => x.Username == username);

            return player;
        }

        public bool Remove(IPlayer player)
        {
            if (player == null)
            {
                throw new ArgumentException("Player cannot be null");
            }

            return players.Remove(player);
        }
    }
}
