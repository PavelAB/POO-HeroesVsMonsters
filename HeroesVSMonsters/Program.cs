using HeroesVSMonsters.Models;

namespace HeroesVSMonsters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Game game = new Game();
            Hero hero = new("bestHero");
            Monster monster = new("firstMonster");
            Monster monster2 = new("secondMonster");

            game.Battle(hero, monster);

            Console.WriteLine($"Hero {hero.Name} : {hero.Health}");
            Console.WriteLine($"Monster {monster.Name} : {monster.Health}");
            Console.WriteLine($"Monster {monster2.Name} : {monster2.Health}");


        }
    }
}
