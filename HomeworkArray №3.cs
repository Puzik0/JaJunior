using System;

namespace HomeworkArray__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 9, 51, 51, 65, 1, 61, 51, 561, 51, 65, 651, 561, 684, 84, 654, 645, 46, 84, 321, 3, 5 };

            int lustArrayIndex = numbers.Length - 1;

            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }

            if (numbers[0] > numbers[1])
            {
                Console.WriteLine($"\nЛокальное максимально значение {numbers[0]}");
            }

            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i - 1] < numbers[i] && numbers[i] > numbers[i + 1])
                {
                    Console.WriteLine($"\nЛокальное максимально значение {numbers[i]}");
                }
            }

            if (numbers[lustArrayIndex] > numbers[lustArrayIndex - 1])
            {
                Console.WriteLine($"\nЛокальное максимально значение {numbers[lustArrayIndex]}");
            }
        }
    }
}
