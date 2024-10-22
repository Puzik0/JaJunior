using System;

namespace HWReadInt
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = GetNumber();

            Console.WriteLine(number);
        }

        static int GetNumber()
        {
            bool isOpen = true;
            int result = 0;

            while (isOpen)
            {
                Console.WriteLine("Введите что-то (но лучше чтоб это было число)");

                bool canConvert = int.TryParse(Console.ReadLine(), out int number);

                if (canConvert == true)
                {
                    result = number;

                    isOpen = false;
                }

                Console.Clear();
            }

            return result;
        }
    }
}
