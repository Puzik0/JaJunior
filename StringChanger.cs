using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringChanger
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string name = "Скучнов";
          string secondname = "Георгий";
          
          Console.WriteLine($"имя: {name}, фамилия {secondname}");
          
          string clipboard = name; 
          name = secondname;
          secondname = clipboard;
          
          Console.WriteLine($"имя: {name}, фамилия {secondname}");
        }
    }
}
