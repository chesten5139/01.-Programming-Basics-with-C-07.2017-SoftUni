using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MinNumber
{
    class MinNumber
    {
        static void Main()
        {
            int countNumber = int.Parse(Console.ReadLine());
            int minNumber = int.MaxValue;
            for (int i = 1; i <= countNumber; i++)
            {
                int userInput = int.Parse(Console.ReadLine());
                minNumber = Math.Min(minNumber, userInput);
            }
            Console.WriteLine(minNumber);
            Console.WriteLine();
        }
    }
}
