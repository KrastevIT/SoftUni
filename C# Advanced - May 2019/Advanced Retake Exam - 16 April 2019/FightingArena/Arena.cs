using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FightingArena
{
    public class Arena
    {
        List<Gladiator> gladiators = new List<Gladiator>();

        public Arena(string name)
        {
            Name = name;
            gladiators = new List<Gladiator>();
        }

        public string Name { get; set; }

        public int Count => gladiators.Count();

        public void Add(Gladiator gladiator)
        {
            gladiators.Add(gladiator);
        }

        public void Remove(string name)
        {
            Gladiator gladiatorToRemove = gladiators
                .FirstOrDefault(x => x.Name == name);

            gladiators.Remove(gladiatorToRemove);
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            return gladiators.OrderByDescending(x => x.GetStatPower()).First();
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            return gladiators.OrderByDescending(x => x.GetWeaponPower()).First();
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            return gladiators.OrderByDescending(x => x.GetTotalPower()).First();
        }

        public override string ToString()
        {
            return $"[{Name}] - [{Count}] gladiators are participating.";
        }
    }
}
