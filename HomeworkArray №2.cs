using System;

namespace HomeworkArray__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumberInArray = int.MinValue;
            int requestedValue = 0;

            int[,] arrey =
            {
                { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 122, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 122, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 122, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 122, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 122 },
            };

            foreach (int item in arrey)
            {
                if (maxNumberInArray < item)
                {
                    maxNumberInArray = item;
                }
            }

            for (int i = 0; i < arrey.GetLength(0); i++)
            {
                for (int j = 0; j < arrey.GetLength(1); j++)
                {
                    Console.Write(arrey[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"\nИсходная матрица и максимально число в ней : {maxNumberInArray}\n");

            for (int i = 0; i < arrey.GetLength(0); i++)
            {
                for (int j = 0; j < arrey.GetLength(1); j++)
                {
                    if (arrey[i, j] == maxNumberInArray)
                    {
                        arrey[i, j] = requestedValue;
                        break;
                    }
                }
            }

            for (int i = 0; i < arrey.GetLength(0); i++)
            {
                for (int j = 0; j < arrey.GetLength(1); j++)
                {
                    Console.Write(arrey[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nИзменённый матрица\n");
        }
    }
}
