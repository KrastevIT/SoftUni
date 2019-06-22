using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Heroes
{
    public class HeroRepository
    {
        List<Hero> heroes = new List<Hero>();

        public HeroRepository()
        {
            heroes = new List<Hero>();
        }

        public int Count => heroes.Count();

        public void Add(Hero hero)
        {
            heroes.Add(hero);
        }

        public void Remove(string name)
        {
            Hero heroToRemove = heroes.FirstOrDefault(x => x.Name == name);

            heroes.Remove(heroToRemove);

        }

        public Hero GetHeroWithHighestStrength()
        {
            return heroes.OrderByDescending(x => x.Item.Strength).First();
        }

        public Hero GetHeroWithHighestAbility()
        {
            return heroes.OrderByDescending(x => x.Item.Ability).First();
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            return heroes.OrderByDescending(x => x.Item.Intelligence).First();
        }

        public override string ToString()
        {
            return $"{string.Join(" ", heroes)}";
        }
    }
}
