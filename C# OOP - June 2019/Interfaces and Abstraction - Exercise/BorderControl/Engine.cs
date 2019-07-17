using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BorderControl
{
    public class Engine
    {
        private List<Identification> identifications;
        public Engine()
        {
            identifications = new List<Identification>();
        }

        public void Run()
        {
            string[] inputArgs = Console.ReadLine().Split();

            while (inputArgs[0] != "End")
            {
                if (inputArgs.Length == 3)
                {
                    string name = inputArgs[0];
                    int age = int.Parse(inputArgs[1]);
                    string id = inputArgs[2];

                    Citizens citizens = new Citizens(id, name, age);

                    identifications.Add(citizens);
                }
                else if (inputArgs.Length == 2)
                {
                    string model = inputArgs[0];
                    string id = inputArgs[1];

                    Robots robots = new Robots(id, model);

                    identifications.Add(robots);
                }

                inputArgs = Console.ReadLine().Split();
            }

            string digitsFakeId = Console.ReadLine();

            foreach (var id in identifications.Where(x => x.Id.EndsWith(digitsFakeId)))
            {
                Console.WriteLine(id.Id);
            }
        }
    }
}
