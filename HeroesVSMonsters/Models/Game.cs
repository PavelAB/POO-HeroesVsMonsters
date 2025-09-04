using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVSMonsters.Models
{
    internal class Game
    {
        public bool Battle(Hero hero, Monster monster, Monster monster2)
        {


            hero.AttackMonster += monster.GetDamage;
            hero.AttackMonster += monster2.GetDamage;
            monster.AttackHero += hero.GetDamage;
            monster2.AttackHero += hero.GetDamage;


            hero.Attack(monster);
            hero.Attack(monster2);
            Console.WriteLine($"Monster {monster2.Name} : {monster2.Health}");


            monster.AttackHero -= hero.GetDamage;
            hero.AttackMonster -= monster.GetDamage;

            if (hero.Health <= 0 || hero.IsAlive == false)
            {


                return false;
            }
            else if (hero.Health > 0){

                hero.GetLoot(monster);
                hero.GetLoot(monster2);
                return true;
            }
            else
            {
                return false; // throw exception
            }
        }
    }
}
