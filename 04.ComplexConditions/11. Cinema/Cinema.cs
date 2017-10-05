using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Cinema
    {
        static void Main()
        {
            string cinemaType = Console.ReadLine().ToLower();
            double rows = double.Parse(Console.ReadLine());
            double columns = double.Parse(Console.ReadLine());
            double seats = rows * columns;
            switch (cinemaType)
            {
                case "premiere":
                    Console.WriteLine("{0:f2} leva", seats * 12);
                    break;
                case "normal":
                    Console.WriteLine("{0:f2} leva", seats * 7.50);
                    break;
                case "discount":
                    Console.WriteLine("{0:f2} leva", seats * 5);
                    break;
            }
        }
    }
}
