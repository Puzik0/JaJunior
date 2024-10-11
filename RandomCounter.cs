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
            int maxNumberForRandom = 99;
            int randomNumberForCount = random.Next(minNumberForRandom, maxNumberForRandom);
            int result = 0;
            int firstRequestedSplitter = 3;
            int secondRequestedSplitter = 5;

            for (int i = 0; i <= randomNumberForCount; i++)
            {
                if (i % firstRequestedSplitter == 0 || i % secondRequestedSplitter == 0 )
                {
                    result = result + i;
                }
            }

            Console.WriteLine($"Сумма чисел от {minNumberForRandom} до {randomNumberForCount} " +
                $"кратные числам {firstRequestedSplitter} или {secondRequestedSplitter} равна = {result} ");
        }
    }
}
