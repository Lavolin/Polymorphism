using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E03Raiding
{
    public class Engine
    {
        private readonly List<BaseHero> heroes;

        public Engine()
        {
            this.heroes = new List<BaseHero>();
        }

        public void Run()
        {
            int numOfHeroes = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfHeroes; i++)
            {

                string name = Console.ReadLine();
                string type = Console.ReadLine();
                BaseHero hero = null;
                if (type == "Druid")
                {
                    hero = new Druid(name);
                }
                else if (type == "Paladin")
                {
                    hero = new Paladin(name);

                }
                else if (type == "Rogue")
                {
                    hero = new Rogue(name);

                }
                else if (type == "Warrior")
                {
                    hero = new Warrior(name);
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                    i--;
                    continue;
                }

                this.heroes.Add(hero);



            }

            int bossPower = int.Parse(Console.ReadLine());
            heroes.ForEach(x => Console.WriteLine(x.CastAbility()));

            int heroesPower = heroes.Sum(x => x.Power);

            string result = heroesPower >= bossPower
                 ? "Victory!"
                 : "Defeat...";
            Console.WriteLine(result);
        }

       
    }
}
