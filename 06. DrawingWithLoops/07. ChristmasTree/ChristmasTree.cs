using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ChristmasTree
{
    class ChristmasTree
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string middle = " | ";

            for (int row = 0; row <= n; row++)
            {
                string spaces = "";
                string stars = "";
                for (int sp = 0; sp < n-row; sp++)
                {
                    spaces += " ";
                }
                for (int st = 0; st < row; st++)
                {
                    stars += "*";

                }
                Console.WriteLine("{0}{1}{2}{3}", spaces, stars, middle, stars);
            }
        }
    }
}
