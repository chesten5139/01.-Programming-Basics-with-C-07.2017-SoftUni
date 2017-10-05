using System;

    class USDToBGN
    {
        static void Main()
        {
        double dollar = double.Parse(Console.ReadLine());
        double leva = Math.Round(dollar * 1.79549,2);
        Console.WriteLine(leva);
        }
    }
