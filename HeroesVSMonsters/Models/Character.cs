using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVSMonsters.Models
{
    internal abstract class Character
    {


        public string Name { get; set; }
        public bool IsAlive { get; set; } = true;
        private double _endurance;
        private double _force;
        private double _health;
        private List<Item> _inventory= new ();

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

        public List<Item> Inventory
        { 
            get { return _inventory; }
            set { _inventory = value; } 
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

        public abstract void Attack();




    }
}
