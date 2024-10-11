using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthUserName;

            string outputSymbolString ="";
            string userName;
            string specialSymbol;

            Console.WriteLine("Введите Ваше имя");

            userName = (Console.ReadLine());

            Console.WriteLine("Введите специальный символ");

            specialSymbol = (Console.ReadLine());

            lengthUserName = userName.Length;

            for (int i = 0; i < lengthUserName; i++)
            {
                outputSymbolString += specialSymbol;
            }

            Console.WriteLine($"{outputSymbolString} \n{userName} \n{outputSymbolString}");
        }
    }
}
