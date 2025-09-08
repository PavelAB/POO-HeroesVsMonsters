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

        

        private int _level;

        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }

        public event AttackMonsterEvent AttackMonster = null;


        public Hero(string Name) : base(Name, "H")
        { 
            Level = 0;
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

        public void NextLevel()
        {
            int increaseProps = Dice.Roll(2);

            if (increaseProps == 1)
                Endurance += 1;
            else if (increaseProps == 2)
                Force += 1;

            Level += 1;
            ResetHealth();
        }
        
        
    }
}
