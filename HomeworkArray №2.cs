using System;

namespace HomeworkArray__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumberInArray = int.MinValue;

            int[,] A =
            {
                { 1, 2, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 9, 1, 1, 1 },
                { 1, 1, 1, 1, 7, 1, 1, 1, 1 },
                { 1, 1, 1, 5, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 117, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 122, 1, 1, 1 },
                { 1, 1, 1, 13, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
            };

            foreach (int item in A)
            {
                if (maxNumberInArray < item)
                {
                    maxNumberInArray = item;
                }
            }

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nИсходная матрица и максимально число в ней : {maxNumberInArray}\n");

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] == maxNumberInArray)
                    {
                        A[i, j] = 0;
                        break;
                    }
                }
            }

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nИзменённый матрица\n");
        }
    }
}
