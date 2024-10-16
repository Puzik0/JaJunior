using System;

namespace HomeworkArray__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int product = 1;
            int stringNumber = 2;
            int columnNumber = 1;
            int[,] array = new int[,]
            {
                { 1, 2 , 3},
                { 3, 4 , 3},
                { 5, 5 , 3},
                { 6, 6 , 3}
            };

            for (int i = 0, j = columnNumber - 1; i < array.GetLength(0); i++)
            {
                product += array[i, j];
            }

            for (int i = stringNumber - 1, j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
            }

            Console.WriteLine($"сумма чисел в строке №{stringNumber}: {sum}. произведение чисел в столбце №{columnNumber}: {product}");
        }
    }
}
