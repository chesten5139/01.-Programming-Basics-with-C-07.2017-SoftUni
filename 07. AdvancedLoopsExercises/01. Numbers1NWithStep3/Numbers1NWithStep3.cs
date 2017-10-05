using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Numbers1NWithStep3
{
    class Numbers1NWithStep3
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i <= n; i++)
            //{
            //    if ((i -1) % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            for (int i = 1; i <= n; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
