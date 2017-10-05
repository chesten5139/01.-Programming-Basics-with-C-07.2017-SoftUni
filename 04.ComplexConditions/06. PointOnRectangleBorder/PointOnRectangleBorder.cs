﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PointOnRectangleBorder
{
    class PointOnRectangleBorder
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool xOnBorder = x == x1 || x == x2;
            bool yOnBorder = y == y1 || y == y2;

            if (xOnBorder && y >= y1 && y <= y2)
            {
                Console.WriteLine("Border");
            }
            else if (yOnBorder && x >= x1 && x <= x2)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
