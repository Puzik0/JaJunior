using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueTimeTreker
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int pictures = 52;
          int rowCapacity = 3;
          
          int rowIsFilled = pictures / rowCapacity;
          int picturesNotInRow = pictures % rowCapacity;
          Console.WriteLine($"заполненныйх рядов с картинками: {rowIsFilled} , картинок осталось: {picturesNotInRow}");
          Console.ReadKey();
        }
    }
}
