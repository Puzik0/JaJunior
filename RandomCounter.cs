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
            Random rand = new Random();
            int number = rand.Next(0, 101);
            int counterThree = 3;
            int counterFive = 5;
            int stepsThree = number / counterThree; 
            int stepsFive = number / counterFive;
            int sumNumbersThree = (counterThree + stepsThree * counterThree) * stepsThree / 2;
            int sumNumbersFive = (counterFive + stepsFive * counterFive) * stepsFive / 2;
            int result = sumNumbersFive+sumNumbersThree;
            Console.WriteLine(result);
        }
    }
}
