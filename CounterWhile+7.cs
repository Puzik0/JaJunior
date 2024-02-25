using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterWhile_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNumber = 5;
            int maxNumber = 103;
            int stepNumber = 7;
            
            while (minNumber <= maxNumber)
            {
                Console.WriteLine(minNumber);
                minNumber += stepNumber;
            }
        }
    }
}
