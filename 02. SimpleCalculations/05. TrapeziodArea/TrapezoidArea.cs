using System;

    class TrapezoidArea
    {
        static void Main()
        {
        var a1 = double.Parse(Console.ReadLine());
        var b1 = double.Parse(Console.ReadLine());
        var h1 = double.Parse(Console.ReadLine());
        var area = (a1 + b1) * h1 / 2;
        Console.WriteLine("Trapezoid area = " + area);
        }
    }
