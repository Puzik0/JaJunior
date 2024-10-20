using System;

namespace HomeworkArrayN5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 1, 2, 3, 5, 4, 5, 8, 5, 5, 5, 6, 6, 6, 6, 6, 6, 2, 2, 2, 3, 2, 1, 1, 1, 4, 4, 4, 8, 9, 9, 9, 9, 6, 3 };
            int counter = 1;
            int counterTemp = 0;
            int number = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    counter++;                    
                }

                else                                    
                {
                    if (counter > counterTemp)         
                    {
                        counterTemp = counter;           
                        number = numbers[i - 1];
                    }

                    counter = 1;                             
                }
            }

            Console.WriteLine($"Число:{number}, кол-во повторений: {counterTemp} ");
        }
    }
}
