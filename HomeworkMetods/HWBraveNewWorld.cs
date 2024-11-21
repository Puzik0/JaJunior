using System;

namespace HWBraveNewWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] map =
            {
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#' },
                {'#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','*','#','*','#' },
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
            char tresur = '*';
            char money = '.';
            char wall = '#';

            int playerCoordinateX = 1;
            int playerCoordinateY = 1;

            while (true)
            {
                Console.Clear();
                DrawMap(map);
                DrawPacman(player, ref playerCoordinateX, ref playerCoordinateY);
                Console.SetCursorPosition(32, 0);
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                MovePlayer(pressedKey, ref playerCoordinateX, ref playerCoordinateY, ref map, wall);
            }
        }

        static void DrawMap(char[,] chars)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            for (int i = 0; i < chars.GetLength(0); i++)
            {
                for (int j = 0; j < chars.GetLength(1); j++)
                {
                    Console.Write(chars[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void MovePlayer(ConsoleKeyInfo pressedKey, ref int x, ref int y, ref char[,] map, char wall)
        {
            int[] direction = GetDirection(pressedKey);
            int nexPositionX = x + direction[0];
            int nexPositionY = y + direction[1];

            if (map[nexPositionX, nexPositionY] != wall)
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

        static void DrawPacman(char player, ref int x, ref int y)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(x, y);
            Console.Write(player);
        }
    }
}
