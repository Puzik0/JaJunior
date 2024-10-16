using System;

namespace HomeworkArray__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int product = 1;
            int[,] array = new int[,]
            {
                { 1, 2 , 3},
                { 3, 4 , 3},
                { 5, 5 , 3},
                { 6, 6 , 3}
            };

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    if (j == 0 && i == 1)
                    {
                        sum += array[i, j];
                        product *= array[i, j];
                    }
                    else if (j == 0)
                    {
                        product *= array[i, j];
                    }
                    else if (i == 1)
                    {
                        sum += array[i, j];
                    }

                }
            }

            Console.WriteLine($"сумма второй строки: {sum}. произведение первого столбца:{product}");
        }
    }
}
