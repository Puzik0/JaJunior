using System;
using System.Xml.Serialization;

namespace HWBraveNewWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] map =
            {
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#' },
                {'#',' ','.','.','.','.','.','.','.','.','.','.','.','.','.','.','*','#','*','#' },
                {'#','#','#','#','#','#','#','#','.','#','#','#','#','#','#','#','#','#','.','#' },
                {'#','.','.','.','.','.','*','#','.','.','#','.','.','.','.','.','.','#','.','#' },
                {'#','.','#','#','#','#','#','#','.','.','#','.','#','.','.','.','.','#','.','#' },
                {'#','.','#','*','.','.','.','.','.','.','#','.','#','.','.','.','.','#','.','#' },
                {'#','.','#','#','#','#','#','#','*','.','#','.','#','.','.','.','.','.','.','#' },
                {'#','.','#','.','.','.','.','#','.','.','#','.','#','.','.','.','.','#','.','#' },
                {'#','.','#','.','#','#','.','#','.','.','#','.','#','.','.','.','#','*','#','#' },
                {'#','.','#','.','.','#','*','#','.','.','#','.','#','.','.','#','.','.','.','#' },
                {'#','.','#','.','.','#','#','#','.','.','#','.','#','.','.','#','.','#','.','#' },
                {'#','.','#','.','.','.','.','.','.','.','#','.','#','.','.','#','.','#','.','#' },
                {'#','.','#','#','#','#','#','#','.','.','.','.','#','.','.','#','.','#','.','#' },
                {'#','.','#','.','.','.','.','#','#','#','#','#','#','#','.','#','.','#','.','#' },
                {'#','.','#','.','.','.','.','.','.','.','.','.','.','.','.','#','.','#','.','#' },
                {'#','.','#','.','.','.','.','.','.','.','.','.','.','.','.','#','.','#','.','#' },
                {'#','.','#','.','.','.','.','.','.','.','.','#','#','#','#','#','.','#','.','#' },
                {'#','.','#','#','#','#','.','.','#','#','#','#','*','#','#','#','.','#','.','#' },
                {'#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','*','#' },
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#' }
            };

            Console.CursorVisible = false;

            char player = '@';
            char treasure = '*';
            char money = '.';
            char wall = '#';
            char road = ' ';

            int coinsInWallet = 0;
            int treasureInWallet = 0;
            int playerCoordinateX = 1;
            int playerCoordinateY = 1;
            int coinsInWalletForWin = 196;
            int treasureInWalletForWin = 9;

            while (coinsInWallet != coinsInWalletForWin || treasureInWallet != treasureInWalletForWin)
            {
                Console.Clear();
                DrawMap(map, money, treasure);
                DrawWallet(coinsInWallet, treasureInWallet);
                DrawPacman(player, ref playerCoordinateX, ref playerCoordinateY);
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                MovePlayer(pressedKey, ref playerCoordinateX, ref playerCoordinateY, ref map, wall);
                TakeTreasures(ref map, road, money, treasure, ref playerCoordinateX, ref playerCoordinateY, ref coinsInWallet, ref treasureInWallet);
            }
<<<<<<< HEAD

            Console.Clear();
            Console.WriteLine($"Большое спасибо за игру! \nВы победили! \nМонет собрано:{coinsInWallet} \nДрагоценностей собрано:{treasureInWallet}");
=======
>>>>>>> d1e0530b719c3c0aaa47c451c21e7388f14509a6
        }

        static void DrawMap(char[,] chars, char coins, char treasure)
        {
            for (int i = 0; i < chars.GetLength(0); i++)
            {
                for (int j = 0; j < chars.GetLength(1); j++)
                {
                    if (chars[i, j] == coins || chars[i, j] == treasure)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(chars[i, j]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(chars[i, j]);
                    }
                }

                Console.WriteLine();
            }
        }

        static void MovePlayer(ConsoleKeyInfo pressedKey, ref int x, ref int y, ref char[,] map, char wall)
        {
            int[] direction = GetDirection(pressedKey);
            int nexPositionX = x + direction[0];
            int nexPositionY = y + direction[1];

            if (map[nexPositionY, nexPositionX] != wall)
            {
                x = nexPositionX;
                y = nexPositionY;
            }
        }

        private static int[] GetDirection(ConsoleKeyInfo pressedKey)
        {
            int[] direction = { 0, 0 };

            if (pressedKey.Key == ConsoleKey.UpArrow)
                direction[1] -= 1;
            else if (pressedKey.Key == ConsoleKey.DownArrow)
                direction[1] += 1;
            else if (pressedKey.Key == ConsoleKey.RightArrow)
                direction[0] += 1;
            else if (pressedKey.Key == ConsoleKey.LeftArrow)
                direction[0] -= 1;

            return direction;
        }

        static void DrawPacman(char player, ref int xPosition, ref int yPosition)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(xPosition, yPosition);
            Console.Write(player);
        }

        static void TakeTreasures(ref char[,] map, char road, char coin, char treasure, ref int xPosition, ref int yPosition, ref int coinsCollected, ref int treasureCollected)
        {
            if (map[yPosition, xPosition] == coin)
            {
                map[yPosition, xPosition] = road;
                coinsCollected++;
            }
            if (map[yPosition, xPosition] == treasure)
            {
                map[yPosition, xPosition] = road;
                treasureCollected++;
            }
        }

        static void DrawWallet(int coinsInWallet, int treasureInWallet)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, 25);
            Console.WriteLine($"Собрано монет: {coinsInWallet}, Собрано драгоценностей: {treasureInWallet}");
        }
    }
}
