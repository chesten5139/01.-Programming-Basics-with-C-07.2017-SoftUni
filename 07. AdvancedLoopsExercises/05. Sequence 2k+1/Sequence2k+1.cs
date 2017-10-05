using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sequence_2k_1
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i = 2 * (i-1)+1)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            int currentNumber = 1;

            while (currentNumber <= n)
            {
                Console.WriteLine(currentNumber);
                currentNumber = 2 * currentNumber + 1;
            }
        }
    }
}
