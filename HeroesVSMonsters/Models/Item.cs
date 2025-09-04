using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVSMonsters.Models
{
    public abstract class Item
    {
        private string _name;


        public string Name { get; set; }

        public Item(string name) {
            Name = name;
        }
        //public static bool operator ==(Item left, Item right)
        //{
        //    if (left.Name == right.Name)
        //        return true;
        //    else 
        //        return false;
        //}
        //public static bool operator !=(Item left, Item right)
        //{
        //    if (left.Name != right.Name)
        //        return true;
        //    else
        //        return false;
        //}
        //public static Item operator +(Item left, Item right)
        //{
        //    return new Item(left.name, left.quantity + right.quantity);
        //}
    }
}
