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
            string breakWord = "exit";
            int homeworkPages = 1;
            string userInput;
            string warning = "Тебе есть, что сказать учителю? \nЕсли нет, то пиши exit";
            Console.WriteLine(warning);
            userInput = Console.ReadLine();
            
            while (breakWord != userInput)
            {
                homeworkPages++;
                Console.WriteLine($"Учитель тебя внимательно выслушал, листов с домашним заданием теперь: {homeworkPages}");
                Console.WriteLine(warning);
                userInput = Console.ReadLine();
            }
            
            switch (homeworkPages) 
            {
                case 1:
                    Console.WriteLine($"Професор Йонду не любит дерзких..." +
                        $"\nДо завтра нужно написать листов с домашкой: {homeworkPages}");
                    break;
                default:
                    Console.WriteLine($"Как обычно вы ушли после лекции не общаясь с профессором Йонду..." +
                        $"\nДо завтра нужно написать листов с домашкой: {homeworkPages}");
                    break;
            }
        }
    }
}
