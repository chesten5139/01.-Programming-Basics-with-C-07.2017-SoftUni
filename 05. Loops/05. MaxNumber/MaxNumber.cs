using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MaxNumber
{
    class MaxNumber
    {
        static void Main()
        {
            int countNumber = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            for (int i = 1; i <= countNumber; i++)
            {
                int userInput = int.Parse(Console.ReadLine());
                maxNumber = Math.Max(maxNumber, userInput);
            }
            Console.WriteLine(maxNumber);
            Console.WriteLine();
        }
    }
}
