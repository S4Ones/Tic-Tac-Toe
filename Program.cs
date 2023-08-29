using System;
using System.IO;
using System.Threading;
using Tic_Tac_Toe;

namespace TicTacToeCsharp
{
    public class Program
    {
        static char[] arrayTable = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        static int player = 1;
        static int choice;

        static int checkWon = 0;

        /// <summary>
        /// Ход игры.
        /// </summary>
        static void Main()
        {
            Draw draw = new Draw();
            GameLogic gameLogic = new GameLogic();

            Console.WriteLine("Игрок 1: X");
            Console.WriteLine("Игрок 2: O");

            do
            {
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine();

                if (player % 2 == 0)
                {
                    Console.WriteLine("Игрок 2: ");
                }
                else
                {
                    Console.WriteLine("Игрок 1 :");
                }

                Console.WriteLine();
                draw.DrawBoard(arrayTable);
                choice = int.Parse(Console.ReadLine());

                if (arrayTable[choice] != 'X' && arrayTable[choice] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        arrayTable[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        arrayTable[choice] = 'X';
                        player++;
                    }
                }
                else
                {
                    Console.WriteLine("Неверный ход, повторите еще раз {1}", choice, arrayTable[choice]);
                    Console.WriteLine();
                }
                checkWon = gameLogic.CheckWin(arrayTable);
            }
            while (checkWon != 1 && checkWon != -1);

            Console.WriteLine();
            draw.DrawBoard(arrayTable);
            Thread.Sleep(1000);
            if (checkWon == 1)
            {
                Console.WriteLine("Игрок {0} победил", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Ничья");
            }
            Console.ReadLine();
        }
    }
}