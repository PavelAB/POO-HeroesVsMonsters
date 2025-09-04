using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Course.utils
{
    public static class Dice
    {
        public static int Minimum = 1;
        public static int Maximum = 6;

        

        public static int Roll()
        {
            Random rnd = new Random();
            return rnd.Next(Minimum, Maximum);
        }
        public static int Roll(int max) 
        {
            Random rnd = new Random();
            return rnd.Next(1, Maximum);
        }
        public static int[] RollInt(int number)
        {
            int[] rolls = new int[number];
            for (int i = 0; i < rolls.Length; i++)
            {
                rolls[i] = Roll();
            }
            return rolls;
        }
        public static int SumOfDices(int[] dices, int bestOf)
        {
            int[] dicesSorted = dices.OrderBy(i => i).ToArray();
            int sum = 0;
            for (int i = 0; i < bestOf; i++)
            {
                sum += dicesSorted[i];
            }
            return sum;
        }
        public static string ToString(int number)
        {
            int[] rolls = RollInt(number);
            string result = string.Empty;
            for(int i = 0; i < rolls.Length; i++)
            {
                result += $"[{rolls[i]}] ";
            }
            return result;
        }
    }
}
