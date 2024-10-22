using System;

namespace HWKansasCityShuffle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            WriteArray(numbers);
            Console.WriteLine();
            ShuffleArray(numbers);
            WriteArray(numbers);

        }

        static void WriteArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }

        static void ShuffleArray(int[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                int randomIndex = random.Next(0, array.Length);
                int tempNumber = array[randomIndex];
                array[randomIndex] = array[i];
                array[i] = tempNumber;
            }
        }
    }
}
