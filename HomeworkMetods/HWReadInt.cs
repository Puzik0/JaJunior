using System;

namespace HWReadInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;

            while (isOpen)
            {
                Console.WriteLine("Введите что-то (но лучше чтоб это было число)");

                string userInput = Console.ReadLine();
                int convertedUserInput = Convertation(userInput);

                if (convertedUserInput != 0)
                {
                    Answer(convertedUserInput);
                }

                Console.WriteLine("\nНажмите любую клавишу...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static int Convertation(string str)
        {
            int number;
            int.TryParse(str, out number);
            return number;
        }

        static void Answer(int num)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Введено число: {num}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
