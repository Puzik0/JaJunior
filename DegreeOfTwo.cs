using System;

namespace DegreeOfTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int RequestedNumber = 2;

            int counterDegree = 0;
            int numberInDegree = 2;

            Random random = new Random();
            int minNumberForRandom = 1;
            int maxNumberForRandom = 100;
            int randomNumberForCount = random.Next(minNumberForRandom, maxNumberForRandom);

            for (int i = RequestedNumber; i <= randomNumberForCount; i *= RequestedNumber)
            {
                counterDegree++;
                numberInDegree = i;
            }

            if (randomNumberForCount >= numberInDegree)
            {
                counterDegree++;
                numberInDegree *= RequestedNumber;
            }

            Console.WriteLine($"число = {randomNumberForCount},\nстепень = {counterDegree}\nдвойка в данной степени = {numberInDegree} ");
        }
    }
}
