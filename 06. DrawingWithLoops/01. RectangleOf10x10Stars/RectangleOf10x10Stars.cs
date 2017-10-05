using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RectangleOf10x10Stars
{
    class RectangleOf10x10Stars
    {
        static void Main()
        {
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    Console.Write("*");
                }

             Console.WriteLine();
            }
        }
    }
}
