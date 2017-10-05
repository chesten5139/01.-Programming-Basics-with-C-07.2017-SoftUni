using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.OddEvenSum
{
    class OddEvenSum
    {
        static void Main()
        {
            int countNumber = int.Parse(Console.ReadLine());
            int odd = 0;
            int even = 0;
            for (int i = 1; i <= countNumber; i++)
            {
                if (i % 2 != 0)
                {
                    int input = int.Parse(Console.ReadLine());
                    odd += input;
                }
                else
                {
                    int input = int.Parse(Console.ReadLine());
                    even += input;

                }
            }
            if (odd == even)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", odd);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("diff = {0}", Math.Abs(odd - even));
            }
        }
    }
}
