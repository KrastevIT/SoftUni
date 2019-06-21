using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FightingArena
{
    public class Gladiator
    {
        public Gladiator(string name, Stat stat, Weapon weapon)
        {
            Name = name;
            Stat = stat;
            Weapon = weapon;
        }

        public string Name { get; set; }

        public Stat Stat { get; set; }

        public Weapon Weapon { get; set; }

        public int GetTotalPower()
        {
            return Stat.Strength +
                   Stat.Flexibility +
                   Stat.Agility +
                   Stat.Skills +
                   Stat.Intelligence +
                   Weapon.Size +
                   Weapon.Solidity +
                   Weapon.Sharpness;

        }

        public int GetWeaponPower()
        {
            return Weapon.Size +
                   Weapon.Solidity +
                   Weapon.Sharpness;
        }

        public int GetStatPower()
        {
            return Stat.Strength +
                      Stat.Flexibility +
                      Stat.Agility +
                      Stat.Skills +
                      Stat.Intelligence;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Name} - {GetTotalPower()}");
            sb.Append($"Weapon Power: {GetWeaponPower()}");
            sb.Append($"Stat Power: {GetStatPower()}");

            return sb.ToString().TrimEnd();
        }

    }
}

