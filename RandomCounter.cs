using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCaunter
{
    internal class Program
    {
         static void Main(string[] args)
        {
            Random random = new Random();
            int minNumberForRandom = 0;
            int maxNumberForRandom = 101;
            int randomNumberForCaunt = random.Next(minNumberForRandom, maxNumberForRandom);
            int result = 0;
            int splitter = 3;
            int splitter1 = 5;

            for (int i = 0; i <= randomNumberForCaunt; i++)
            {
                if (i / splitter > (i - 1) / splitter || i / splitter1 > (i - 1) / splitter1)
                {
                    result = result + i;
                }
            }

            Console.WriteLine($"Сумма чисел от {minNumberForRandom} до {randomNumberForCaunt} кратные числам {splitter} и {splitter1} равна = {result} ");
        }
    }
}
