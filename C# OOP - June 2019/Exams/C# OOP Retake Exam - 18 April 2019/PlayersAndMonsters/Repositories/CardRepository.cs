using PlayersAndMonsters.Models.Cards.Contracts;
using PlayersAndMonsters.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayersAndMonsters.Repositories
{
    public class CardRepository : ICardRepository
    {
        private IList<ICard> cards;
        public CardRepository()
        {
            this.cards = new List<ICard>();
        }
        public int Count => this.cards.Count;

        public IReadOnlyCollection<ICard> Cards => this.cards.ToList();

        public void Add(ICard card)
        {
            if (card == null)
            {
                throw new ArgumentException("Card cannot be null!");
            }

            if (this.cards.Any(x => x.Name == card.Name))
            {
                throw new ArgumentException($"Card {card.Name} already exists!");
            }

            this.cards.Add(card);
        }

        public ICard Find(string name)
        {
            var card = this.cards.FirstOrDefault(x => x.Name == name);

            return card;
        }

        public bool Remove(ICard card)
        {
            if (card == null)
            {
                throw new ArgumentException("Card cannot be null!");
            }

            return this.cards.Remove(card);
        }
    }
}
