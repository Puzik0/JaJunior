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
                СonvertInNumber(userInput);

                Console.WriteLine("\nНажмите любую клавишу...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void СonvertInNumber(string value)
        {
           bool canConvert = int.TryParse(value, out int result);  

            if (canConvert == true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Введено число: {result}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
