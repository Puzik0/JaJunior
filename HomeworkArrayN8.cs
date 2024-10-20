using System;

namespace HomeworkArrayN8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            Console.WriteLine($"Введите, сколько раз необходимо сдвинуть массив, но не более чем {numbers.Length}");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput > numbers.Length ) 
            {
                Console.WriteLine("Вы ввели слишком большое значение"); 
            }

            else
            {
                for (int i = 0; i < userInput; i++)
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

                foreach (int item in numbers)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
