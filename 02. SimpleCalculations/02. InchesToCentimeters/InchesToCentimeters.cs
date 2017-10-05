using System;

    class InchesToCentimeters
    {
        static void Main()
        {
        var inch = double.Parse(Console.ReadLine());
        var toCentimeters = inch * 2.54;
        Console.WriteLine(toCentimeters);
        }
    }
