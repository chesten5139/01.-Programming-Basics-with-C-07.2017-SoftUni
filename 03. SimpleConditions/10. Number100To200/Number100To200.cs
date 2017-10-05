using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Number100To200
{
    class Number100To200
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            if (input < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (input >= 100 && input <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
            {
                Console.WriteLine("Greater than 200");
            }

        }
    }
}
