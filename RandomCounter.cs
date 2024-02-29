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
            int oldBufer = 0;
            int oldBufer1 = 0;
            int splitter = 3;
            int splitter1 = 5;

            for (int i = 0; i <= randomNumberForCaunt; i++)
            {
                int newBufer = i / splitter;
                int newBufer1 = i / splitter1;

                if (newBufer > oldBufer && newBufer1 > oldBufer1) 
                {
                    result = result + i;
                    oldBufer++;
                    oldBufer1++;
                }

                else if (newBufer > oldBufer) 
                {
                    result = result + i;
                    oldBufer++;
                }

                else if (newBufer1 > oldBufer1)
                {
                    result = result + i;
                    oldBufer1++;
                }
            }

            Console.WriteLine($"Сумма чисел от {minNumberForRandom} до {randomNumberForCaunt} кратные числам {splitter} и {splitter1} равна = {result} ");
        }
    }
}
