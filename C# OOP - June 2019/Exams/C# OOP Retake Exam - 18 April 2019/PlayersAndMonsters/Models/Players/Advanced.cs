using System;
using System.Collections.Generic;
using System.Text;
using PlayersAndMonsters.Repositories.Contracts;

namespace PlayersAndMonsters.Models.Players
{
    public class Advanced : Player
    {
        private const int InitialHealthPoints = 250;
        public Advanced(ICardRepository cardRepository, string userName) 
            : base(cardRepository, userName, InitialHealthPoints)
        {
        }
    }
}
