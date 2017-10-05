using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.GreatestCommonDivisor
{
    class GCD
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            //int gcd = 1;
            //int minNumber = Math.Min(a, b);

            //for (int i = 2; i <= minNumber; i++)
            //{
            //    if (a % i == 0 && b % i == 0)
            //    {
            //        gcd = i;
            //    }
            //}
            //Console.WriteLine(gcd);


            int biggerNumber = Math.Max(a, b);
            int smallerNumber = Math.Min(a, b);
            int remainder = biggerNumber % smallerNumber;

            while (remainder != 0)
            {
                biggerNumber = smallerNumber;
                smallerNumber = remainder;
                remainder = biggerNumber % smallerNumber;
            }
            Console.WriteLine(smallerNumber);
        }
    }
}
