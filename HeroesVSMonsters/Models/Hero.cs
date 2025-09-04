using POO_Course.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVSMonsters.Models
{
    internal delegate void AttackMonsterEvent(Hero hero, Monster monster);
    internal class Hero : Character
    {

        const int NUMBER_BEST_OF_ROLL_STATS = 3;
        const int ROLL_NUMBER_OF_DICES_STATS = 4;

        public event AttackMonsterEvent AttackMonster = null;


        public Hero(string Name)
        {
            this.Name = Name;
            Endurance = Dice.SumOfDices(Dice.RollInt(ROLL_NUMBER_OF_DICES_STATS), NUMBER_BEST_OF_ROLL_STATS);
            Force = Dice.SumOfDices(Dice.RollInt(ROLL_NUMBER_OF_DICES_STATS), NUMBER_BEST_OF_ROLL_STATS);
            Health = Endurance + GetModifier(Endurance) + 300;
        }



        public void Attack(Monster monster)
        {
            AttackMonster?.Invoke(this, monster);
        }
        public void GetDamage(Monster monster)
        {
            double damage = Dice.Roll(4) + GetModifier(monster.Force);
            Health -= damage;


            if (Health <= 0)
                IsAlive = false;


            if (IsAlive)
                Attack(monster);

        }

        public void GetLoot(Monster monster)
        {
            foreach ((Item key, int value) in monster.Inventory)
            {
                var match = Inventory.FirstOrDefault(item => item.Key.Name == key.Name);

                if (!match.Equals(default(KeyValuePair<Item, int>)))
                {
                    Inventory[match.Key] += value;
                }
                else
                {
                    Inventory.Add(key, value);
                }
            }
        }
        
    }
}
