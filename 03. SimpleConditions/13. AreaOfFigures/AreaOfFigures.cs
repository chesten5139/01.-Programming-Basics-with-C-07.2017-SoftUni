using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main()
        {
            string input = Console.ReadLine();
            double firstLine = 0;
            double secondLine = 0;
            if (input == "square")
            {
                firstLine = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(firstLine * firstLine,3));
            }
            else if (input == "circle")
            {
                firstLine = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(firstLine * firstLine * Math.PI,3));
            }
            else if (input == "rectangle")
            {
                firstLine = double.Parse(Console.ReadLine());
                secondLine = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(firstLine * secondLine,3));
            }
            else if (input == "triangle")
            {
                firstLine = double.Parse(Console.ReadLine());
                secondLine = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((firstLine * secondLine) / 2,3));
            }
        }
    }
}
