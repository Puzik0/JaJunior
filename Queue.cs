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
            int personInFront;
            int allMinutes;
            int minutesInHour = 60;
            int hoursToWait;
            int minutesToWait;
            
            Console.WriteLine("Сколько сейчас человек перед Вами?");
            personInFront = Convert.ToInt32(Console.ReadLine());
            allMinutes = personInFront * timeForOnePerson;
            hoursToWait = allMinutes / minutesInHour;
            minutesToWait = allMinutes % minutesInHour;
            Console.WriteLine($"Вам тут еще тарчать {hoursToWait} ч. и {minutesToWait} мин.");
            Console.ReadKey(); 
        }
    }
}
