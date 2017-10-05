using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Time15Minutes
{
    class Time15Minutes
    {
        static void Main()
        {
            int inputHour = int.Parse(Console.ReadLine());
            int inputMinutes = int.Parse(Console.ReadLine());
            int totalMinutes = inputHour * 60 + inputMinutes + 15;
            int resultHour = totalMinutes / 60;
            if (resultHour >=24)
            {
                resultHour -= 24;
            }
            int resultMinutes = totalMinutes % 60;
            Console.WriteLine("{0}:{1:00}",resultHour,resultMinutes);
        }
    }
}
