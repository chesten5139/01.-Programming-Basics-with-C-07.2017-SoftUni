using System;

    class RadiansToDegrees
    {
        static void Main()
        {
        double rad = double.Parse(Console.ReadLine());
        double grad = Math.Round(rad*57.29578);
        Console.WriteLine(grad);
        }
    }