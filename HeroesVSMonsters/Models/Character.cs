using POO_Course.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVSMonsters.Models
{
    internal abstract class Character
    {
        const int NUMBER_BEST_OF_ROLL_STATS = 3;
        const int ROLL_NUMBER_OF_DICES_STATS = 4;

        public string Name { get; set; }
        public bool IsAlive { get; set; } = true;
        private double _endurance;
        private double _force;
        private double _health;

        private string _icon;
        private int _positionX;
        private int _positionY;
        private Dictionary<Item, int> _inventory = new ();

        public double Endurance
        {
            get { return _endurance; }
            set { _endurance = value; }
        }
        public double Force
        {
            get { return _force; }
            set { _force = value; }
        }
        public double Health
        {
            get { return _health; }
            set { _health = value; }
        }
        
        public int PositionX {
            get { return _positionX; }
            set { _positionX = value; }
        }
        public int PositionY {
            get { return _positionY; }
            set { _positionY = value; }
        }
        public string Icon
        {
            get { return _icon; }
            set { _icon = value; }
        }

        public Dictionary<Item, int> Inventory
        { 
            get { return _inventory; }
            set { _inventory = value; } 
        }
        public Character(
            string name, 
            string icon,
            double enduranceModifier = 0,
            double forceModifier = 0,
            double healthModifier = 0 )
            {
                Name = name;
                Icon = icon;
                Endurance = Dice.SumOfDices(Dice.RollInt(ROLL_NUMBER_OF_DICES_STATS), NUMBER_BEST_OF_ROLL_STATS) + enduranceModifier;
                Force = Dice.SumOfDices(Dice.RollInt(ROLL_NUMBER_OF_DICES_STATS), NUMBER_BEST_OF_ROLL_STATS) + forceModifier;
                Health = Endurance + GetModifier(Endurance) + healthModifier;
                PositionX = Dice.Roll(0, 14);
                PositionY = Dice.Roll(0, 14);

        }

        public void ResetHealth()
        {
            Health = Endurance + GetModifier(Endurance);
        }


        public double GetModifier(double stat)
        {
            if (stat < 5)
                return -1d;
            else if (stat < 10)
                return 0d;
            else if (stat < 15)
                return 1d;
            return 2d;
        }

        //public abstract void Attack(Monster monster);

        public override string ToString()
        {
            return $"{Name}: \n" +
                $"\t Health : {Health} \n" +
                $"\t Force : {Force} \n" +
                $"\t Endurance : {Endurance} \n";
        }


    }
}
