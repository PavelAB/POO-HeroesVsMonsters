using HeroesVSMonsters.Models.Items;
using POO_Course.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVSMonsters.Models
{
    internal delegate void AttackHeroEvent(Monster monster);
    internal class Monster : Character
    {


        public Monster(string name): base(name, "M")
        {
            Inventory = new Dictionary<Item, int> { 
                { new Gold(), Dice.Roll() }, 
                { new Leather(), Dice.Roll(4) } 
            };
        }


        public event AttackHeroEvent AttackHero;
        public void Attack()
        {
            AttackHero?.Invoke(this);
        }
        public void GetDamage(Hero hero, Monster monster)
        {
            if(this.Name == monster.Name)
            {
                double damage = Dice.Roll(4) + GetModifier(hero.Force);
                Health -= damage;


                if (Health <= 0)
                    IsAlive = false;

                if (IsAlive)
                    Attack();
            }
            

        }

    }

}
