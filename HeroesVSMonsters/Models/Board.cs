using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVSMonsters.Models
{
    internal class Board
    {
        public const int BOARD_LENGTH = 15;

        public string[,] GameBoard = new string[BOARD_LENGTH, BOARD_LENGTH];


        public Board()
        {
            for (int i = 0; i < GameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < GameBoard.GetLength(1); j++)
                {
                    GameBoard[i, j] = "_";
                }

            }
        }

        public void displayBoard()
        {
            for (int i = 0; i < GameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < GameBoard.GetLength(1); j++)
                {
                    Console.Write($"{GameBoard[i, j]} ");
                }
                Console.WriteLine();
            }
        }

    }
}
