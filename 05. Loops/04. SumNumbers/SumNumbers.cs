using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SumNumbers
{
    class SumNumbers
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= input; i++)
            {
                int userInput = int.Parse(Console.ReadLine());
                sum += userInput;
            }
            Console.WriteLine(sum);
        }
    }
}
