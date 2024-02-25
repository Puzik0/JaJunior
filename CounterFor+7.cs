using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNumber = 5;
            int maxNumber = 103;
            int stepNumber = 7;
            int steps = (maxNumber - minNumber) / stepNumber;
            int result = minNumber;

            for (int i = 0; i <= steps ; i++)
            {
                Console.WriteLine(result);
                result += stepNumber;
            }
        }
    }
}
