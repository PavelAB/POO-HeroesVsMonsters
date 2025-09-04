using HeroesVSMonsters.Models;

namespace HeroesVSMonsters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Hero bestHero = new("bestHero");
            Monster monster = new("firstMonster");
            Monster monster2 = new("secondMonster");

            bestHero.AttackMonster += monster.GetDamage;
            //bestHero.AttackMonster += monster2.GetDamage;
            monster.AttackHero += bestHero.GetDamage;
            //monster2.AttackHero += bestHero.GetDamage;


            bestHero.Attack();


            Console.WriteLine($"Hero {bestHero.Name} : {bestHero.Health}");
            Console.WriteLine($"Monster {monster.Name} : {monster.Health}");
            Console.WriteLine($"Monster {monster2.Name} : {monster2.Health}");

            if (bestHero.IsAlive == false || bestHero.Health <= 0)
                monster.AttackHero -= bestHero.GetDamage;
            if (monster.IsAlive == false || monster.Health <= 0)
                bestHero.AttackMonster -= monster.GetDamage;

        }
    }
}
