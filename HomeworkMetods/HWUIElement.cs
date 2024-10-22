using System;

namespace HWUIElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrawBar(0, 4, 10, ConsoleColor.Green, "Здоровье");
            DrawBar(1, 50, 10, ConsoleColor.Blue, "Мана");
        }

        static void DrawBar(int YPosition, int value, int maxValue, ConsoleColor color, string barName = "Bar", char specialSymbolPoints = ' ', char specialSymbolLostPoints = ' ')
        {
            char openBar = '[';
            char closeBar = ']';
            ConsoleColor defaultColor = Console.BackgroundColor;

            if (value == 0.4 * maxValue)
            {
                specialSymbolPoints = '#';
                specialSymbolLostPoints = '_';
            }

            string bar = "";

            for (int i = 0; i < value; i++)
            {
                bar += specialSymbolPoints;
            }

            Console.SetCursorPosition(0, YPosition);
            Console.Write(openBar);
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;

            bar = "";

            for (int i = value; i < maxValue; i++)
            {
                bar += specialSymbolLostPoints;
            }

            Console.Write(bar);
            Console.Write(closeBar);
            Console.Write("-" + barName);
        }
    }
}
