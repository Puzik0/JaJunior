using System;

namespace DegreeOfTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int RequestedNumber = 2;

            int counterDegree = 1;
            int numberInDegree = 2;

            Random random = new Random();
            int minNumberForRandom = 1;
            int maxNumberForRandom = 100;
            int randomNumberForCount = random.Next(minNumberForRandom, maxNumberForRandom);

            while (numberInDegree <= randomNumberForCount)
            {
                numberInDegree *= RequestedNumber;
                counterDegree++;
            }

            Console.WriteLine($"число = {randomNumberForCount},\nстепень = {counterDegree}\n{RequestedNumber} в данной степени = {numberInDegree} ");
        }
    }
}
