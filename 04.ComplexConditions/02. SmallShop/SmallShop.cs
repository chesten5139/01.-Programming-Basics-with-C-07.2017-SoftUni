using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SmallShop
{
    class SmallShop
    {
        static void Main()
        {
            string product = Console.ReadLine().ToLower();
            string town = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            if (product == "coffee")
            {
                if (town == "sofia")
                {
                    Console.WriteLine(quantity * 0.5);
                }
                else if (town == "plovdiv")
                {
                    Console.WriteLine(quantity * 0.4);
                }
                else if (town == "varna")
                {
                    Console.WriteLine(quantity * 0.45);
                }

            }
            else if (product == "water")
            {
                if (town == "sofia")
                {
                    Console.WriteLine(quantity * 0.8);
                }
                else if (town == "plovdiv")
                {
                    Console.WriteLine(quantity * 0.7);
                }
                else if (town == "varna")
                {
                    Console.WriteLine(quantity * 0.7);
                }

            }
            else if (product == "beer")
            {
                if (town == "sofia")
                {
                    Console.WriteLine(quantity * 1.2);
                }
                else if (town == "plovdiv")
                {
                    Console.WriteLine(quantity * 1.15);
                }
                else if (town == "varna")
                {
                    Console.WriteLine(quantity * 1.1);
                }

            }
            else if (product == "sweets")
            {
                if (town == "sofia")
                {
                    Console.WriteLine(quantity * 1.45);
                }
                else if (town == "plovdiv")
                {
                    Console.WriteLine(quantity * 1.3);
                }
                else if (town == "varna")
                {
                    Console.WriteLine(quantity * 1.35);
                }

            }
            else if (product == "peanuts")
            {
                if (town == "sofia")
                {
                    Console.WriteLine(quantity * 1.6);
                }
                else if (town == "plovdiv")
                {
                    Console.WriteLine(quantity * 1.5);
                }
                else if (town == "varna")
                {
                    Console.WriteLine(quantity * 1.55);
                }

            }
        }
    }
}
