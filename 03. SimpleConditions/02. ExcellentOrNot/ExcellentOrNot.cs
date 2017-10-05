using System;

    class ExcellentOrNot
    {
        static void Main()
        {
        double note = double.Parse(Console.ReadLine());
        if (note >= 5.50)
        {
            Console.WriteLine("Excellent!");
        }
        else
        {
            Console.WriteLine("Not excellent.");
        }
    }
    }
