using PlayersAndMonsters.Core.Contracts;
using PlayersAndMonsters.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private IManagerController managerController;

        public Engine(IReader reader, IWriter writer, IManagerController managerController)
        {
            this.reader = reader;
            this.writer = writer;
            this.managerController = managerController;
        }

        public void Run()
        {
            while (true)
            {
                string line = this.reader.ReadLine();

                if (line == "Exit")
                {
                    break;
                }

                string[] lineParts = line.Split();
                string commad = lineParts[0];

                string result = string.Empty;
                string cardName = string.Empty;

                switch (commad)
                {
                    case "AddPlayer":
                        string playerType = lineParts[1];
                        string playerUserName = lineParts[2];
                        result = managerController.AddPlayer(playerType, playerUserName);
                        break;
                    case "AddCard":
                        string cardType = lineParts[1];
                        cardName = lineParts[2];
                        result = managerController.AddCard(cardType, cardName);
                        break;
                    case "AddPlayerCard":
                        string username = lineParts[1];
                        cardName = lineParts[2];
                        result = managerController.AddPlayerCard(username, cardName);
                        break;
                    case "Fight":
                        string attackUser = lineParts[1];
                        string enemyUser = lineParts[2];
                        result = managerController.Fight(attackUser, enemyUser);
                        break;
                    case "Report":
                        result = managerController.Report();
                        break;
                    default:
                        break;
                }

                this.writer.WriteLine(result);
            }
        }
    }
}
