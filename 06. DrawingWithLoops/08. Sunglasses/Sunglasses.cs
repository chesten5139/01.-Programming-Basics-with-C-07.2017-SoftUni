using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sunglasses
{
    class Sunglasses
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new string('*', 2 * n), new string(' ', n));

            string slashes = new string('/', 2 * n - 2);
            string spaces = new string(' ', n);
            string pipes = new string('|', n);

            for (int row = 0; row < n - 2; row++)
            {
                if (n % 2 == 0 && row == n / 2 - 2 || (n%2==1 && row == n/2 -1))
                {
                    Console.WriteLine($"*{slashes}*{pipes}*{slashes}*");
                }
                else
                {
                    Console.WriteLine($"*{slashes}*{spaces}*{slashes}*");
                }
            }
            Console.WriteLine("{0}{1}{0}", new string('*', 2 * n), new string(' ', n));
        }
    }
}
