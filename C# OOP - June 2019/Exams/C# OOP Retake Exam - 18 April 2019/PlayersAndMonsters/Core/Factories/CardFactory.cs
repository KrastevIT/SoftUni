using PlayersAndMonsters.Core.Factories.Contracts;
using PlayersAndMonsters.Models.Cards.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace PlayersAndMonsters.Core.Factories
{
    public class CardFactory : ICardFactory
    {
        public ICard CreateCard(string type, string name)
        {
            Type cardType = Assembly.GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name.StartsWith(type));

            var card = (ICard)Activator.CreateInstance(cardType, name);

            return card;
        }
    }
}
