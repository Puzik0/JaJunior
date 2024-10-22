using System;
using System.Xml.Schema;

namespace HWUIElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrawBar(0, 40, 10, ConsoleColor.Green, "Здоровье"); 
            DrawBar(1, 39, 50, ConsoleColor.Blue, "Манa \n\n");
        }

        static void DrawBar(int positionY, int valuePercent, double maxValue, ConsoleColor color, string barName = "Bar", char specialSymbolPoints = ' ', char specialSymbolLostPoints = ' ')
        {
            char barOpener = '[';
            char barCloser = ']';

            double charActivator = 40;
            double maxPercent = 100;

            double value = (maxValue / maxPercent) * valuePercent;

            ConsoleColor defaultColor = Console.BackgroundColor;

            if (valuePercent == charActivator)
            {
                specialSymbolPoints = '#';
                specialSymbolLostPoints = '_';
            }

            FillPartBar(value, specialSymbolPoints, out string bar);

            Console.SetCursorPosition(0, positionY);
            Console.Write(barOpener);
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;

            FillPartBar(maxValue - value, specialSymbolLostPoints, out string barEmpty);

            Console.Write(barEmpty);
            Console.Write(barCloser);
            Console.Write("-" + barName);
        }

        static void FillPartBar(double value, char specialSymbol, out string bar)
        {
            bar = "";

            for (int i = 0; i < value; i++)
            {
                bar += specialSymbol;
            }
        }
    }
}
