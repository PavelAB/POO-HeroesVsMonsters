using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVSMonsters.Models
{
    internal class Game
    {
        

        public bool Battle(Hero hero, Monster monster)
        {


            hero.AttackMonster += monster.GetDamage;
            //hero.AttackMonster += monster2.GetDamage;
            monster.AttackHero += hero.GetDamage;
            //monster2.AttackHero += hero.GetDamage;


            hero.Attack(monster);
            //hero.Attack(monster2);
            //Console.WriteLine($"Monster {monster2.Name} : {monster2.Health}");


            monster.AttackHero -= hero.GetDamage;
            hero.AttackMonster -= monster.GetDamage;

            if (hero.Health <= 0 || hero.IsAlive == false)
            {


                return false;
            }
            else if (hero.Health > 0){

                hero.GetLoot(monster);
                hero.NextLevel();
                //hero.GetLoot(monster2);
                return true;
            }
            else
            {
                return false; // throw exception
            }
        }

        public void GetPositions(List<Character> characters, Board board)
        {
            foreach (Character character in characters)
            {
                if(character is not null)
                    board.GameBoard[character.PositionY, character.PositionX] = character.Icon;
            }
        }

        public string moveDirectionPlayer()
        {
            string choice = null;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Faites votre choix: ");
                Console.WriteLine("g : Gauche");
                Console.WriteLine("d : Droite");
                Console.WriteLine("z : Haut");
                Console.WriteLine("s : Bas");
                Console.WriteLine("q : Quit");

                choice = Console.ReadLine();
            } while (!(choice == "q" || choice == "d" || choice == "g" || choice == "z" || choice == "s"));

            return choice;
        }

        public void moveCharacter(string choice, Character character, Board board)
        {
            int action = (choice == "g" || choice == "z") ? -1 : 1;

            // gauche - OK
            if (choice == "g" && character.PositionX == 0)
            {
                board.GameBoard[character.PositionY, board.GameBoard.GetLength(1) + action] = character.Icon;
                board.GameBoard[character.PositionY, character.PositionX] = "_";
                character.PositionX = board.GameBoard.GetLength(1) + action;
            }
            // droite - OK
            else if (choice == "d" && character.PositionX == board.GameBoard.GetLength(1) - 1)
            {
                board.GameBoard[character.PositionY, 0] = character.Icon;
                board.GameBoard[character.PositionY, character.PositionX] = "_";
                character.PositionX = 0;
            }
            // bas
            else if (choice == "s" && character.PositionY == board.GameBoard.GetLength(1) - 1)
            {
                board.GameBoard[0, character.PositionX] = character.Icon;
                board.GameBoard[character.PositionY, character.PositionX] = "_";
                character.PositionY = 0;
            }
            //haut
            else if (choice == "z" && character.PositionY == 0)
            {
                board.GameBoard[board.GameBoard.GetLength(1) + action, character.PositionX] = character.Icon;
                board.GameBoard[character.PositionY, character.PositionX] = "_";
                character.PositionY = board.GameBoard.GetLength(1) + action;
            }

            //else if ((choice == "g" || choice == "d"))
            //{
            //    board.GameBoard[character.PositionX, character.PositionY + action] = character.Icon;
            //    board.GameBoard[character.PositionX, character.PositionY] = "_";
            //    character.PositionY = character.PositionY + action;
            //}
            // G,D - OK
            else if ((choice == "g" || choice == "d"))
            {
                board.GameBoard[character.PositionY, character.PositionX + action] = character.Icon;
                board.GameBoard[character.PositionY, character.PositionX] = "_";
                character.PositionX = character.PositionX + action;
            }
            //else if ((choice == "s" || choice == "z"))
            //{
            //    board.GameBoard[character.PositionX + action, character.PositionY] = character.Icon;
            //    board.GameBoard[character.PositionX, character.PositionY] = "_";
            //    character.PositionX = character.PositionX + action;
            //}
            else if ((choice == "s" || choice == "z"))
            {
                board.GameBoard[character.PositionY + action, character.PositionX] = character.Icon;
                board.GameBoard[character.PositionY, character.PositionX] = "_";
                character.PositionY = character.PositionY + action;
            }
        }

        

    }
}
