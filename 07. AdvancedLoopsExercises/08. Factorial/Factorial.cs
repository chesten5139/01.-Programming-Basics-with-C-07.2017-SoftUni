using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Factorial
{
    class Factorial
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int result = 1;
            int counter = 1;

            do
            {
                result *= counter;
                counter++;
            } while (counter <= n);

            Console.WriteLine(result);
        }
    }
}
