using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.NumberInRange1To100
{
    class NumberInRange1To100
    {
        static void Main()
        {
            Console.Write("Enter a number in the range[1...100]: ");

            int n = int.Parse(Console.ReadLine());

            while (!(n >= 1 && n <= 100))
            {
                Console.WriteLine("Invalid number!");
                Console.Write("Enter a number in the range[1...100]: ");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The number is: {0}", n);

        }
    }
}
