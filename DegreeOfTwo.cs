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

             for (int i = RequestedNumber; randomNumberForCount >= numberInDegree; i *= RequestedNumber)
            {
                counterDegree++;
                numberInDegree = i;
            }

            Console.WriteLine($"число = {randomNumberForCount},\nстепень = {counterDegree}\nдвойка в данной степени = {numberInDegree} ");
        }
    }
}
