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
            int result;

            while (int.TryParse(Console.ReadLine(), out result) == false)
            {
                Console.WriteLine("Введено некорректное значение");
            }

            return result;
        }
    }
}
