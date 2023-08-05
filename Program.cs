using System;
using System.IO;
using System.Threading;

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
                DrawBoard();
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
                checkWon = CheckWin();
            }
            while (checkWon != 1 && checkWon != -1);

            Console.WriteLine();
            DrawBoard();
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

        /// <summary>
        /// Прорисовка поля.
        /// </summary>
        private static void DrawBoard()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arrayTable[1], arrayTable[2], arrayTable[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arrayTable[4], arrayTable[5], arrayTable[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arrayTable[7], arrayTable[8], arrayTable[9]);
            Console.WriteLine("     |     |      ");
        }

        /// <summary>
        /// Проверка на выйгрышь.
        /// </summary>
        /// <returns>Победа, ничья.</returns>
        private static int CheckWin()
        {
            if ((arrayTable[1] == arrayTable[2] && arrayTable[2] == arrayTable[3]) && (arrayTable[1] != ' ' && arrayTable[2] != ' ' && arrayTable[3] != ' '))
            {
                return 1;
            }
            else if ((arrayTable[4] == arrayTable[5] && arrayTable[5] == arrayTable[6]) && (arrayTable[4] != ' ' && arrayTable[5] != ' ' && arrayTable[6] != ' '))
            {
                return 1;
            }
            else if ((arrayTable[6] == arrayTable[7] && arrayTable[7] == arrayTable[8]) && (arrayTable[6] != ' ' && arrayTable[7] != ' ' && arrayTable[8] != ' '))
            {
                return 1;
            }
            else if ((arrayTable[1] == arrayTable[4] && arrayTable[4] == arrayTable[7]) && (arrayTable[1] != ' ' && arrayTable[4] != ' ' && arrayTable[7] != ' '))
            {
                return 1;
            }
            else if ((arrayTable[2] == arrayTable[5] && arrayTable[5] == arrayTable[8]) && (arrayTable[2] != ' ' && arrayTable[5] != ' ' && arrayTable[5] != ' '))
            {
                return 1;
            }
            else if ((arrayTable[3] == arrayTable[6] && arrayTable[6] == arrayTable[9]) && (arrayTable[3] != ' ' && arrayTable[6] != ' ' && arrayTable[9] != ' '))
            {
                return 1;
            }
            else if ((arrayTable[1] == arrayTable[5] && arrayTable[5] == arrayTable[9]) && (arrayTable[1] != ' ' && arrayTable[5] != ' ' && arrayTable[9] != ' '))
            {
                return 1;
            }
            else if ((arrayTable[3] == arrayTable[5] && arrayTable[5] == arrayTable[7]) && (arrayTable[3] != ' ' && arrayTable[5] != ' ' && arrayTable[7] != ' '))
            {
                return 1;
            }
            else if (arrayTable[1] != ' ' && arrayTable[2] != ' ' && arrayTable[3] != ' ' && arrayTable[4] != ' ' && arrayTable[5] != ' ' && arrayTable[6] != ' ' && arrayTable[7] != ' ' && arrayTable[8] != ' ' && arrayTable[9] != ' ')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

    }
}