using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LeftAndRightSum
{
    class LeftAndRightSum
    {
        static void Main()
        {
            int countNumber = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < countNumber; i++)
            {
                int input = int.Parse(Console.ReadLine());
                leftSum += input;
            }

            for (int i = 0; i < countNumber; i++)
            {
                int input = int.Parse(Console.ReadLine());
                rightSum += input;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = {0}", rightSum);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(leftSum - rightSum));
            }
        }
    }
}
