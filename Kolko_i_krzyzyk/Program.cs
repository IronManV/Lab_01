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
            PlayerHuman gA = new PlayerHuman();
            PlayerComputer gB = new PlayerComputer();
            gA.Name = "User";
            gB.Name = "Computer";
            gA.Symbol = 'x';
            gB.Symbol = 'o';


            char[,] board = new char[3, 3] {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }
            };

            //A loop over players moves
            bool gameOver = false;
            bool movePlayerA = true;
            while (!gameOver)
            {
                Console.Clear();
                DrawBorad(board);

                if (movePlayerA)
                {
                    Console.WriteLine("current player: " + gA.Name);
                    gameOver = gA.MakeMove(board);
                    movePlayerA = false;
                }
                else
                {
                    Console.WriteLine("current player: " + gB.Name);
                    gameOver = gB.MakeMove(board);
                    movePlayerA = true;
                }
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
    interface IMove
    {
        bool MakeMove(char[,] board);
    }

    abstract class Player
    {
        public string Name { get; set; }
        public char Symbol { get; set; }
    }

    class PlayerHuman : Player, IMove
    {
        public bool MakeMove(char[,] board)
        {
            return false; // to correct
        }
    }

    class PlayerComputer : Player, IMove
    {
         public bool MakeMove(char[,] board)
        {
            return false; //to correct
        }
    }
}
