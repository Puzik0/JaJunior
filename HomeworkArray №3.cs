using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkArray__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 9, 51, 51, 65, 1, 61, 51, 561, 51, 65, 651, 561, 684, 84, 654, 645, 46, 84, 321, 3, 5 };

            foreach (int item in array)
            {
                Console.Write(item + " ");
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0 || i == array.Length - 1)
                {
                    if (i == 0 && array[i] > array[i + 1])
                    {
                        Console.WriteLine($"\nЛокальное максимально значение {array[i]}");
                    }
                    else if (i == array.Length - 1 && array[i] > array[i - 1])
                    {
                        Console.WriteLine($"\nЛокальное максимально значение {array[i]}");
                    }
                }
                else if (array[i - 1] < array[i] && array[i] > array[i + 1])
                {
                    Console.WriteLine($"\nЛокальное максимально значение {array[i]}");
                }
            }
        }
    }
}
