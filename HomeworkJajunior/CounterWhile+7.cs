using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterWhile_7
{
    internal class Program
    {
            int minNumber = 5;
            int maxNumber = 103;
            int stepNumber = 7;
            int result = minNumber;

            while (result <= maxNumber)
            {
                Console.WriteLine(result);
                result += stepNumber;
            }
        }
    }
}
