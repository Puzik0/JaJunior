using System;

namespace MultiplesOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minNumberForRandom = 10;
            int maxNumberForRandom = 25;
            int randomNumberForCount = random.Next(minNumberForRandom, maxNumberForRandom);

            int minCountSpace = 50;
            int maxCountSpace = 150;
            int counterOfNumbersInclude = 0;

            for (int i = minCountSpace; i <= maxCountSpace; i += randomNumberForCount)
            {
                counterOfNumbersInclude++;
            }

            Console.WriteLine($" Число {randomNumberForCount}, кол-во кратных чисел {counterOfNumbersInclude} \n в промежутке между {minCountSpace} и {maxCountSpace}");
        }
    }
}
