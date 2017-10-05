using System;

    class GreaterNumber
    {
        static void Main()
        {
        int firstInput = int.Parse(Console.ReadLine());
        int secondInput = int.Parse(Console.ReadLine());

        int greaterNumber = Math.Max(firstInput, secondInput);

        Console.WriteLine(greaterNumber);
        //if (firstInput>secondInput)
        //{
        //    Console.WriteLine(firstInput);
        //}
        //else
        //{
        //    Console.WriteLine(secondInput);
        //}
        }
    }