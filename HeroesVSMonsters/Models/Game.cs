using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVSMonsters.Models
{
    internal class Game
    {



        public void Battle(Hero hero, Monster monster)
        {
            hero.AttackMonster += monster.GetDamage;
            monster.AttackHero += hero.GetDamage;


            hero.Attack();

            monster.AttackHero -= hero.GetDamage;
            hero.AttackMonster -= monster.GetDamage;
        }
    }
}
