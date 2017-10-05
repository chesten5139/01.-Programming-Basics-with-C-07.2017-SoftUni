using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.InvalidNumber
{
    class InvalidNumber
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            bool isInRange = input >= 100 && input <= 200 || input == 0;

            if (!isInRange)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
