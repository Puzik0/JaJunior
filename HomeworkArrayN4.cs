using System;

namespace HomeworkArrayN4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandToExit = "exit";
            const string CommandToSum = "sum";
            const int arrayPositionX = 0;
            const int arrayPositionY = 20;

            bool isOpen = true;
            int[] numbers = new int[1];
            int sum = 0;
            string userInput = "";

            while (isOpen)
            {
                Console.Clear();
                Console.SetCursorPosition(arrayPositionX, arrayPositionY);

                foreach (int item in numbers)
                {
                    Console.Write(item + " ");
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine($"Напишите число для добавления в массив,\n{CommandToSum} - для вывода суммы всех чисел в массиве\n{CommandToExit}- для выхода из приложения");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandToExit:
                        isOpen = false;
                        break;

                    case CommandToSum:

                        foreach (int item in numbers)
                        {
                            sum += item;
                        }

                        Console.WriteLine("Сумма чисел в массиве = " + sum);
                        Console.WriteLine("Нажмите любую клавишу для продолжения...");
                        Console.ReadKey();
                        break;

                    default:
                        int userNumber = Convert.ToInt32(userInput);
                        int[] tempArrayNumbers = new int[numbers.Length + 1];

                        for (int i = 0; i < numbers.Length; i++)
                        {
                            tempArrayNumbers[i] = numbers[i];
                        }

                        tempArrayNumbers[numbers.Length - 1] = userNumber;
                        numbers = tempArrayNumbers;
                        break;
                }
            }
        }
    }
}
