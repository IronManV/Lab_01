using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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

            char[,] boardCopy = board.Clone() as char[,];

            //A loop over players moves
            bool gameOver = false;
            bool movePlayerA = true;
            for (int round = 0; round < board.Length; ++round)
            {
                Console.Clear();
                DrawBorad(board);

                if (movePlayerA)
                {
                    Console.WriteLine("current player: " + gA.Name);
                    gameOver = gA.MakeMove(board, boardCopy);
                    movePlayerA = false;
                }
                else
                {
                    Console.WriteLine("current player: " + gB.Name);
                    gameOver = gB.MakeMove(board, boardCopy);
                    movePlayerA = true;
                }
                if (gameOver)
                    break;
            }

            //Game ending
            Console.Clear();
            DrawBorad(board);
            Console.Write("Game over!");

            if (gameOver)
            {
                Console.Write("The winner is");
                if (movePlayerA)
                    Console.WriteLine(gB.Name);
                else
                    Console.WriteLine(gA.Name);
                
            }
            else
                Console.WriteLine("A tie.");
            Console.ReadKey();
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
        bool MakeMove(char[,] board, char[,] boardCopy);
    }

    abstract class Player
    {
        public string Name { get; set; }
        public char Symbol { get; set; }

        public bool CheckIfGameOver(char[,] board)
        {
            int height = board.GetLength(0);
            int width = board.GetLength(1);
            if (width != height)
                throw new Exception("The board is not a square!");

            //check rows
            for(int i = 0; i < height; i++)
            {
                int sumOfRow = 0;
                for (int j = 0; j < width; j++)
                {
                    if (board[i, j] == Symbol)
                        sumOfRow++;
                }
                if (sumOfRow == width)
                    return true;
            }
            //check columns
            for (int j = 0; j < width; j++)
            {
                int sumOfColumn = 0;
                for (int i = 0; i < height; i++)
                {
                    if (board[i, j] == Symbol)
                        sumOfColumn++;
                }
                if (sumOfColumn == height)
                    return true;
            }
            //check diagonals
            int sumOfDiagonalA = 0;
            int sumOfDiagonalB = 0;
            for(int k = 0;k < width; k++)
            {
                if (board[k, k] == Symbol)
                    sumOfDiagonalA++;
                if (board[k, width - 1 - k] == Symbol)
                    sumOfDiagonalB++;
            }
            if (sumOfDiagonalA == width || sumOfDiagonalB == width)
                return true;

            return false;
        }
        public bool placeSymbol(char c, char[,] board, char[,] boardCopy)
        {
            int height = board.GetLength(0);
            int width = board.GetLength(1);
            if(height != boardCopy.GetLength(0) || width != boardCopy.GetLength(1))
                throw new Exception("Board sizes dont match!");

            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                    {
                    if ((board[i, j] == c) && (board[i,j] == boardCopy[i,j]))
                        {
                            board[i,j] = Symbol;
                            return true;
                        }   
                    }
            return false;
        }
        
    }

    class PlayerHuman : Player, IMove
    {
        public bool MakeMove(char[,] board, char[,] boardCopy)
        {
            char chosenPalce;
            do
            {
                Console.Write("Choose afree space: ");
                chosenPalce = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
            while (!placeSymbol(chosenPalce, board, boardCopy));

            return CheckIfGameOver(board);
        }
    }

    class PlayerComputer : Player, IMove
    {
         public bool MakeMove(char[,] board, char[,] boardCopy)
        {
            Random rnd = new Random();
            char chosenPalce;
            do
            {
                int m = rnd.Next(1, board.Length + 1);
                chosenPalce = m.ToString()[0];
            }
            while(!placeSymbol(chosenPalce, board, boardCopy));
            Thread.Sleep(2000);

            return CheckIfGameOver(board);
        }
    }
}
