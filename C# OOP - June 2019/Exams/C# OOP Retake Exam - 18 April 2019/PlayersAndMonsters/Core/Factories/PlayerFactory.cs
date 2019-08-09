using PlayersAndMonsters.Core.Factories.Contracts;
using PlayersAndMonsters.Models.Players.Contracts;
using System;
using System.Reflection;
using System.Linq;
using PlayersAndMonsters.Repositories;

namespace PlayersAndMonsters.Core.Factories
{
    public class PlayerFactory : IPlayerFactory
    {
        public IPlayer CreatePlayer(string type, string username)
        {
            Type playerType = Assembly
                .GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name == type);

            var player = (IPlayer)Activator.CreateInstance(playerType, new CardRepository(), username);

            return player;
        }
    }
}
