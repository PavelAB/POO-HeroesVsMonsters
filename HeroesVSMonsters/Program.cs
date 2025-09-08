using HeroesVSMonsters.Models;

namespace HeroesVSMonsters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Hello, World!");

            Game game = new Game();
            Hero hero = new("bestHero");
            Monster monster = new("firstMonster");
            Console.WriteLine(monster.ToString());
            Monster monster2 = new("secondMonster");
            Console.WriteLine(monster2.ToString());
            

            Console.WriteLine($"{hero.ToString()}");


            foreach ((Item key, int value) in monster.Inventory)
            {
                Console.WriteLine($"{key.Name} : {value}");
            }
            foreach ((Item key, int value) in monster2.Inventory)
            {
                Console.WriteLine($"{key.Name} : {value}");
            }
            Console.WriteLine("Hero");

            foreach ((Item key, int value) in hero.Inventory)
            {
                Console.WriteLine($"{key.Name} : {value}");
            }




            //game.Battle(hero, monster, monster2);
            game.Battle(hero, monster);
            game.Battle(hero, monster2);

            Console.WriteLine($"Hero {hero.Name} : {hero.Health}");
            Console.WriteLine($"Monster {monster.Name} : {monster.Health}");
            Console.WriteLine($"Monster {monster2.Name} : {monster2.Health}");

            Console.WriteLine("Hero After");

            Console.WriteLine($"{hero.ToString()}");

            foreach ((Item key, int value) in hero.Inventory)
            {
                Console.WriteLine($"{key.Name} : {value}");
            }

        }
    }
}
