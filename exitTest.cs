using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int homeworkGoodEnding = 1;
            int homeworkPages = 1;
            string breakWord = "exit";
            string userInput;
            string warning = $"Тебе есть, что сказать учителю? \nЕсли нет, то пиши {breakWord}";

            Console.WriteLine(warning);
            userInput = Console.ReadLine();

            while (breakWord != userInput)
            {
                homeworkPages++;
                Console.WriteLine($"Учитель тебя внимательно выслушал, листов с домашним заданием теперь: {homeworkPages}");
                Console.WriteLine(warning);
                userInput = Console.ReadLine();
            }

            string counterOfHomework = $"\nДо завтра нужно написать листов с домашкой: {homeworkPages}";

            switch (homeworkPages) 
            {
                case homeworkGoodEnding:
                    Console.WriteLine($"Как обычно вы ушли после лекции не общаясь с профессором Йонду..." +counterOfHomework);
                    break;

                default:
                    Console.WriteLine($"Професор Йонду не любит дерзких..." +counterOfHomework);
                    break;
            }
        }
    }
}
