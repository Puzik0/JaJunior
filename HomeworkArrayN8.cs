using System;

namespace HomeworkArrayN8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            int sortTimes = 2;

            Console.WriteLine("Массив");

            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }

            for (int i = 0; i < sortTimes; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int tempNumber = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = tempNumber;
                    }
                }
            }

            Console.WriteLine($"\n\nОтсортированный массив со сдвигом {sortTimes} раз");

            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }
        }
    }
}
