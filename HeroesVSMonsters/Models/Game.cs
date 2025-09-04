using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVSMonsters.Models
{
    internal class Game
    {
        public bool Battle(Hero hero, Monster monster)
        {
            hero.AttackMonster += monster.GetDamage;
            monster.AttackHero += hero.GetDamage;


            hero.Attack();

            monster.AttackHero -= hero.GetDamage;
            hero.AttackMonster -= monster.GetDamage;

            if(hero.Health <= 0 || hero.IsAlive == false)
            {


                return false;
            }
            else if (hero.Health > 0){


                return true;
            }
            else
            {
                return false; // throw exception
            }
        }
    }
}
