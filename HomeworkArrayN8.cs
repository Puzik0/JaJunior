using System;

namespace HomeworkArrayN8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            Console.WriteLine("сколько раз сортировать");

            int userInput = Convert.ToInt32(Console.ReadLine());

            int sortTimes = userInput % numbers.Length;

            Console.WriteLine("Массив");

            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }

            for (int i = 0; i < sortTimes; i++)
            {
                int tempNumber = numbers[0];

                for (int j = 1; j < numbers.Length; j++)
                {
                    numbers[j - 1] = numbers[j];
                }

                numbers[numbers.Length - 1] = tempNumber;
            }

            Console.WriteLine($"\n\nОтсортированный массив со сдвигом {sortTimes} раз");

            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }
        }
    }
}
