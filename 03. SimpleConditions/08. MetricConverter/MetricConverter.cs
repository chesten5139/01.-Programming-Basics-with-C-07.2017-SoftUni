using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MetricConverter
{
    class MetricConverter
    {
        static void Main()
        {
            double numbersToConvert = double.Parse(Console.ReadLine());
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();
            var currencies = new Dictionary<string, double>()
            {
                {"m", 1 },
                {"mm", 1000 },
                {"cm", 100 },
                {"mi", 0.000621371192},
                {"in", 39.3700787},
                {"km", 0.001},
                {"ft", 3.2808399},
                {"yd", 1.0936133}
            };
            double result = numbersToConvert / currencies[firstNumber] * currencies[secondNumber];

            Console.WriteLine("{0} {1}", result, secondNumber);

            //double inputNumber = double.Parse(Console.ReadLine());
            //string inputEntry = Console.ReadLine();
            //string inputExit = Console.ReadLine();
            //double firstNumber = 0;
            //double secondNumber = 0;
            //double meter = 1;
            //double millimeters = 1000;
            //double centimeters = 100;
            //double miles = 0.000621371192;
            //double inches = 39.3700787;
            //double kilometers = 0.001;
            //double feet = 3.2808399;
            //double yards = 1.0936133;

            //switch (inputEntry)
            //{
            //    case "m":
            //        firstNumber = inputNumber / meter;
            //        break;
            //    case "mm":
            //        firstNumber = inputNumber / millimeters;
            //        break;
            //    case "cm":
            //        firstNumber = inputNumber / centimeters;
            //        break;
            //    case "mi":
            //        firstNumber = inputNumber / miles;
            //        break;
            //    case "in":
            //        firstNumber = inputNumber / inches;
            //        break;
            //    case "km":
            //        firstNumber = inputNumber / kilometers;
            //        break;
            //    case "ft":
            //        firstNumber = inputNumber / feet;
            //        break;
            //    case "yd":
            //        firstNumber = inputNumber / yards;
            //        break;
            //}
            //switch (inputExit)
            //{
            //    case "m":
            //        secondNumber = firstNumber * meter;
            //        break;
            //    case "mm":
            //        secondNumber = firstNumber * millimeters;
            //        break;
            //    case "cm":
            //        secondNumber = firstNumber * centimeters;
            //        break;
            //    case "mi":
            //        secondNumber = firstNumber * miles;
            //        break;
            //    case "in":
            //        secondNumber = firstNumber * inches;
            //        break;
            //    case "km":
            //        secondNumber = firstNumber * kilometers;
            //        break;
            //    case "ft":
            //        secondNumber = firstNumber * feet;
            //        break;
            //    case "yd":
            //        secondNumber = firstNumber * yards;
            //        break;
            //}
            //string displayString = secondNumber.ToString("0.00000000");
            //Console.WriteLine(displayString);
        }
    }
}
