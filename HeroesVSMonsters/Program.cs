using HeroesVSMonsters.Models;
using POO_Course.utils;

namespace HeroesVSMonsters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Character> characters = new List<Character>();
            List<Monster> monsters = new List<Monster>();

            Game game = new Game();
            Board gameBoard = new Board();
            Hero hero = new("bestHero");
            
            
            characters.Add(hero);
            Monster monster = new("firstMonster");
            
            monsters.Add(monster);
            Monster monster2 = new("secondMonster");
            
            monsters.Add(monster2);

            
            

            game.GetPositions(characters, monsters, gameBoard);
            int test = 0;
            gameBoard.displayBoard();

            while (test < 10)
            {
                game.moveCharacter(game.moveDirectionPlayer(), hero, gameBoard);
                game.IsBattle(hero, monsters, gameBoard);
                
                gameBoard.displayBoard();
            }


        }
    }
}
