namespace PlayersAndMonsters.Core
{
    using System;
    using System.Linq;
    using System.Text;
    using Contracts;
    using PlayersAndMonsters.Common;
    using PlayersAndMonsters.Core.Factories.Contracts;
    using PlayersAndMonsters.Models.BattleFields.Contracts;
    using PlayersAndMonsters.Repositories;
    using PlayersAndMonsters.Repositories.Contracts;

    public class ManagerController : IManagerController
    {
        private IPlayerRepository playerRepository;
        private IPlayerFactory playerFactory;
        private ICardFactory cardFactory;
        private ICardRepository cardRepository;
        private IBattleField battleField;
        public ManagerController(
            IPlayerFactory playerFactory,
            IPlayerRepository playerRepository,
            ICardFactory cardFactory,
            ICardRepository cardRepository,
            IBattleField battleField)
        {
            this.playerFactory = playerFactory;
            this.playerRepository = playerRepository;
            this.cardFactory = cardFactory;
            this.cardRepository = cardRepository;
            this.battleField = battleField;
        }

        public string AddPlayer(string type, string username)
        {
            var player = playerFactory.CreatePlayer(type, username);
            playerRepository.Add(player);

            return string.Format(
                ConstantMessages.SuccessfullyAddedPlayer, type, username);
        }

        public string AddCard(string type, string name)
        {
            var card = this.cardFactory.CreateCard(type, name);
            this.cardRepository.Add(card);

            return string.Format(
                ConstantMessages.SuccessfullyAddedCard, type, name);
        }

        public string AddPlayerCard(string username, string cardName)
        {
            var player = this.playerRepository.Players
                .FirstOrDefault(x => x.Username == username);

            var card = this.cardRepository.Cards
                .FirstOrDefault(x => x.Name == cardName);

            player.CardRepository.Add(card);

            return string.Format(
                ConstantMessages.SuccessfullyAddedPlayerWithCards, cardName, username);
        }

        public string Fight(string attackUser, string enemyUser)
        {
            var attack = this.playerRepository.Players
                  .FirstOrDefault(x => x.Username == attackUser);

            var enemy = this.playerRepository.Players
                .FirstOrDefault(x => x.Username == enemyUser);

            this.battleField.Fight(attack, enemy);

            return string.Format(
                ConstantMessages.FightInfo, attack.Health, enemy.Health);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var player in this.playerRepository.Players)
            {
                sb.AppendLine(player.ToString());

                foreach (var card in player.CardRepository.Cards)
                {
                    sb.AppendLine(card.ToString());
                }

                sb.AppendLine(string.Format(ConstantMessages.DefaultReportSeparator));
            }

           return sb.ToString().TrimEnd();
        }
    }
}
