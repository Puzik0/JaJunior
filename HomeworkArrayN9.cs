using System;

namespace HomeworkArrayN9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int deepCounter = 0;
            int deep = 0;

            char openDeep = '(';
            char closeDeep = ')'; 

            Console.WriteLine($"Введите строку содержащую только данные символы - {openDeep} и {closeDeep}");

            string userInput = Console.ReadLine();

            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] == openDeep)
                {
                    deepCounter++;

                    if (deepCounter > deep)
                    {
                        deep = deepCounter;
                    }
                }

                else if (userInput[i] == closeDeep)
                {
                    deepCounter--;

                    if (deepCounter < 0)
                    {
                        break;
                    }
                }
            }

            if (deepCounter == 0)
            {
                Console.WriteLine($"Максимальна глубина строки {deep}");
            }

            else
            {
                Console.WriteLine("строка не корректная");
            }
        }
    }
}
