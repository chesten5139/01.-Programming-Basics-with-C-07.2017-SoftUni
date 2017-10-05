using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumSeconds
{
    class SumSeconds
    {
        static void Main()
        {
            int firstInput = int.Parse(Console.ReadLine());
            int secondInput = int.Parse(Console.ReadLine());
            int thirdInput = int.Parse(Console.ReadLine());
            int sum = firstInput + secondInput + thirdInput;
            int minutes = sum / 60;
            int seconds = sum - (minutes * 60);
            if (seconds < 10)
            {
                Console.WriteLine("{0}:0{1}",minutes,seconds);
            }
            else
            {
                Console.WriteLine("{0}:{1}",minutes,seconds);
            }
        }
    }
}
