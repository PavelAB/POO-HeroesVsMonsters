using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVSMonsters.Models
{
    internal class Item
    {
        private string _name;
        private int _quantity;


        public string Name { get; set; }
        public int Quantity { get; set; }

        public Item(string name, int quantity) {
            Quantity = quantity;
            Name = name;
        }
        public static bool operator ==(Item left, Item right)
        {
            if (left.Name == right.Name)
                return true;
            else 
                return false;
        }
        public static bool operator !=(Item left, Item right)
        {
            if (left.Name != right.Name)
                return true;
            else
                return false;
        }
        public static Item operator +(Item left, Item right)
        {
            return new Item(left.Name, left.Quantity + right.Quantity);
        }
    }
}
