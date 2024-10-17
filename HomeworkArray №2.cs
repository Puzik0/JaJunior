using System;

namespace HomeworkArray__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumberInArray = int.MinValue;
            int requestedValue = 0;

            int[,] numbers =
            {
                { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 122, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 122, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 122, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 122, 122, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 122 },
            };

            foreach (int item in numbers)
            {
                if (maxNumberInArray < item)
                {
                    maxNumberInArray = item;
                }
            }

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"\nИсходная матрица и максимально число в ней : {maxNumberInArray}\n");

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if (numbers[i, j] == maxNumberInArray)
                    {
                        numbers[i, j] = requestedValue;
                    }
                }
            }

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nИзменённый матрица\n");
        }
    }
}
