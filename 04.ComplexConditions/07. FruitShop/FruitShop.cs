using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FruitShop
{
    class FruitShop
    {
        static void Main()
        {
            string fruit = Console.ReadLine().ToLower();
            string weekDay = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            bool validFruit = fruit == "banana" || fruit == "apple" || fruit == "orange" || fruit == "grapefruit"
                           || fruit == "kiwi" || fruit == "pineapple" || fruit == "grapes";
            bool validWorkDay = weekDay == "monday" || weekDay == "tuesday" || weekDay == "wednesday" 
                || weekDay == "thursday"|| weekDay == "friday";
            bool validWeekEnd = weekDay == "saturday" || weekDay == "sunday";

            if (validFruit && validWorkDay || validWeekEnd)
            {
                if (validWorkDay)
                {
                    switch (fruit)
                    {
                        case "banana":
                            Console.WriteLine(quantity * 2.50);
                            break;
                        case "apple":
                            Console.WriteLine(quantity * 1.20);
                            break;
                        case "orange":
                            Console.WriteLine(quantity * 0.85);
                            break;
                        case "grapefruit":
                            Console.WriteLine(quantity * 1.45);
                            break;
                        case "kiwi":
                            Console.WriteLine(quantity * 2.70);
                            break;
                        case "pineapple":
                            Console.WriteLine(quantity * 5.50);
                            break;
                        case "grapes":
                            Console.WriteLine(quantity * 3.85);
                            break;
                    }
                }
                else
                {
                    switch (fruit)
                    {
                        case "banana":
                            Console.WriteLine(quantity * 2.70);
                            break;
                        case "apple":
                            Console.WriteLine(quantity * 1.25);
                            break;
                        case "orange":
                            Console.WriteLine(quantity * 0.90);
                            break;
                        case "grapefruit":
                            Console.WriteLine(quantity * 1.60);
                            break;
                        case "kiwi":
                            Console.WriteLine(quantity * 3.00);
                            break;
                        case "pineapple":
                            Console.WriteLine(quantity * 5.60);
                            break;
                        case "grapes":
                            Console.WriteLine(quantity * 4.20);
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
