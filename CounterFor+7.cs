using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterFor_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int minNumber = 5;
            int maxNumber = 103;
            int step = 7;

            for (int i = minNumber; i <= maxNumber; i+=step)
            {
                Console.WriteLine(minNumber);
                minNumber += step;
            }
        }
    }
}
