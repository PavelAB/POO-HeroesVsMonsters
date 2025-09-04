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


        public Monster(string name)
        {
            Name = name;
            Endurance = 0;
            Force = 1;
            Health = 10 + GetModifier(Endurance) + 100;
        }


        public event AttackHeroEvent AttackHero;
        public override void Attack()
        {
            AttackHero?.Invoke(this);
        }
        public void GetDamage(Hero hero)
        {
            double damage = Dice.Roll(4) + GetModifier(hero.Force);
            Health -= damage;

            Console.WriteLine($"Monster health {Health}");


            if (Health <= 0)
                IsAlive = false;

            if (IsAlive)
                Attack();

        }

    }

}
