using System;
using System.Collections.Generic;
using System.Text;
using PlayersAndMonsters.Repositories.Contracts;

namespace PlayersAndMonsters.Models.Players
{
    public class Beginner : Player
    {
        private const int InitialHealthPoints = 50;
        public Beginner(ICardRepository cardRepository, string userName)
            : base(cardRepository, userName, InitialHealthPoints)
        {
        }
    }
}
