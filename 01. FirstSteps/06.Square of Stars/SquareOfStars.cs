﻿using System;

    class SquareOfStars
    {
        static void Main()
        {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(new string('*', n));
        for (int i = 1; i <= n - 2; i++)
        Console.WriteLine(new string('*', 1) + new string(' ', n - 2) + new string('*', 1));
        Console.WriteLine(new string ('*', n));
        }
    }

