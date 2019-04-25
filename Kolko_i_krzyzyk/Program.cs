using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolko_i_krzyzyk
{
    class Program
    {
        static void Main(string[] args)
        {
            // mai n code for tictactoe game
            string playerName1 = "";
            string playerName2 = "";
            char playerSymbolX = 'x';
            char playerSymbolO = 'o';
            char[,] board = new char[3, 3] {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }
            };

            Console.WriteLine("Enter name of player 1: ");
            playerName1 = Console.ReadLine();
            Console.WriteLine("Enter name of player 2: ");
            playerName2 = Console.ReadLine();

            //A loop over players moves
            bool gameOver = false;
            while (!gameOver)
            {
                Console.Clear();
                DrawBorad(board);

                Console.ReadKey();
            }

            
        }

        static void DrawBorad(char[,] board)
        {
            int height = board.GetLength(0);
            int width = board.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(board[i,j]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
