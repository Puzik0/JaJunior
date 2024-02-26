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
            int randomNumberForCaunt = random.Next(0, 101);
            int caunter1 = 3;
            int caunter2 = 5;
            int sumOfnumber1 = 0;
            int sumOfnumber2 = 0;
            int issueNumber = caunter1 * caunter2;
            int result;

            Console.WriteLine("Ваше рандомное число:" + randomNumberForCaunt);

            for (int i = 0; i <= randomNumberForCaunt; i += caunter1)
            {
                sumOfnumber1 = sumOfnumber1 + i;
            }

            Console.WriteLine("Сумма чисел кратных трём:" + sumOfnumber1);

            for (int i = 0; i <= randomNumberForCaunt; i += caunter2)
            {
                sumOfnumber2 = sumOfnumber2 + i;
            }

            Console.WriteLine("Сумма чисел кратных пяти:" + sumOfnumber2);

            result = sumOfnumber2 + sumOfnumber1;

            for (int i = 0; i <= randomNumberForCaunt; i += issueNumber)
            {
                result = result - i;
            }

            Console.WriteLine("Сумма всех натуральных чисел кратных трём или пяти "+result);
        }
    }
}
