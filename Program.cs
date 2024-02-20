using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaJunior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int weightMan = 0;
            int weightWoman = 0;
            float haightMan = 0f;
            float haightWoman = 0f;
            string greeting = "Привет! Пожалуйста, укажите ваш вест и рост, а также вес и рост вашего партнёра";
            bool isCompatible = true;

            Console.WriteLine(greeting);
            Console.Write("Вес мужчины: = ");
            weightMan = Convert.ToInt32(Console.ReadLine());
            Console.Write("Рост мужчины: = ");
            haightMan = Convert.ToInt32(Console.ReadLine());
            Console.Write("Вес женщины: = ");
            weightWoman = Convert.ToInt32(Console.ReadLine());
            Console.Write("Рост женщины: = ");
            haightWoman = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Изучаем совместимость, пожалуйста, подождите");

            isCompatible = CompatiblityCheck(weightMan, haightMan, weightWoman, haightWoman); // Включать только если ты токсик.

            Console.WriteLine($"Результат совместимости...");
            if (isCompatible == true)
            {
                Console.WriteLine("Вы на 100% совместимы");
            }
            else
            {
                Console.WriteLine("Вы такие разные, но ни чего не мешает Вам быть вместе");
            }

        }

        private static bool CompatiblityCheck(int weightMan, float haightMan, int weightWoman, float haightWoman)
        {

            int skinny = 19;
            int normal = 25;
            int fatty = 30;
            double manStats = weightMan / (haightMan / 100 * 2);
            double womanStats = weightWoman / (haightWoman / 100 * 2);
            int statusMan;
            int statusWoman;
            bool compatiblityChech = true;

            if (manStats < skinny)
            {
                statusMan = skinny;
                Console.WriteLine("А пацан то хиляк");
            }
            else if (manStats > skinny || manStats < fatty)
            {
                statusMan = normal;
                Console.WriteLine("Парень красавчик");
            }
            else if (manStats >= fatty)
            {
                statusMan = fatty;
                Console.WriteLine("Мужик, ты чёт перестарался");
            }

            if (womanStats < skinny)
            {
                statusWoman = skinny;
                Console.WriteLine("Кто девочку не кормит?");
            }
            else if (womanStats > skinny || manStats < fatty)
            {
                statusWoman = normal;
                Console.WriteLine("Девушка - краса");
            }
            else if (manStats >= fatty)
            {
                statusWoman = fatty;
                Console.WriteLine("Девушка, ну красавица, ну зачем вы так с собой?");
            }

           return compatiblityChech = womanStats == manStats;

        }
    }
}
