using System;

namespace HomeworkArrayN6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            for (int i = 0; i < numbers.Length - 1; i++)
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

            foreach (int item in numbers) { Console.Write(item + " "); }
        }
    }
}
