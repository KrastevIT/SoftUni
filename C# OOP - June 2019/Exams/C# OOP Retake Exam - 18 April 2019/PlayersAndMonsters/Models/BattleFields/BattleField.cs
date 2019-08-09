using PlayersAndMonsters.Models.BattleFields.Contracts;
using PlayersAndMonsters.Models.Players;
using PlayersAndMonsters.Models.Players.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PlayersAndMonsters.Models.BattleFields
{
    public class BattleField : IBattleField
    {
        public void Fight(IPlayer attackPlayer, IPlayer enemyPlayer)
        {
            if (attackPlayer.IsDead || enemyPlayer.IsDead)
            {
                throw new ArgumentException("Player is dead!");
            }

            if (attackPlayer is Beginner)
            {
                this.BoostBeginnerPlayer(attackPlayer);
            }

            if (enemyPlayer is Beginner)
            {
                this.BoostBeginnerPlayer(enemyPlayer);
            }


            BoostPlayer(attackPlayer);
            BoostPlayer(enemyPlayer);

            int attackDamagePoint = attackPlayer
                   .CardRepository
                   .Cards.Sum(x => x.DamagePoints);

            int enemyDamagePoint = enemyPlayer
                   .CardRepository
                   .Cards.Sum(x => x.DamagePoints);

            while (true)
            {
                enemyPlayer.TakeDamage(attackDamagePoint);

                if (enemyPlayer.IsDead)
                {
                    break;
                }

                attackPlayer.TakeDamage(enemyDamagePoint);

                if (attackPlayer.IsDead)
                {
                    break;
                }
            }
        }

        private static void BoostPlayer(IPlayer player)
        {
            int playerBonusHealth = player
                            .CardRepository
                            .Cards
                            .Sum(x => x.HealthPoints);

            player.Health += playerBonusHealth;
        }

        private void BoostBeginnerPlayer(IPlayer player)
        {
            player.Health += 40;

            foreach (var card in player.CardRepository.Cards)
            {
                card.DamagePoints += 30;
            }

        }
    }
}
