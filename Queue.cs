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
            int timeForOnePerson = 10;
            int PersonInFront;
            int allMinutes;
            int minutesInHour = 60;

            int hours;
            int minutes;

            Console.WriteLine("Сколько сейчас человек перд Вами?");
            PersonInFront = Convert.ToInt32(Console.ReadLine());

            allMinutes = PersonInFront * timeForOnePerson;
            hours = allMinutes / minutesInHour;
            minutes = allMinutes % minutesInHour;

            Console.WriteLine($"Вам тут еще тарчать {hours} ч. и {minutes} мин.");
            Console.ReadKey(); 

        }
    }
}
