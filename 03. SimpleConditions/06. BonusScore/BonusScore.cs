using System;

class BonusScore
    {
    static void Main()
    {
        double input = double.Parse(Console.ReadLine());
        string inputInString = input.ToString();
        char lastChar = inputInString[inputInString.Length - 1];
        double bonusScore = 0;
        double finalBonusScore;
        if (input % 2 == 0)
        {
            bonusScore = 1;
        }
        else if (lastChar == '5')
        {
            bonusScore = 2;
        }
        if (input > 1000)
        {
            finalBonusScore = bonusScore + input / 10;
            Console.WriteLine(finalBonusScore);
            Console.WriteLine(finalBonusScore + input);
        }
        else if (input > 100 && input <= 1000)
        {
            finalBonusScore = bonusScore + input / 5;
            Console.WriteLine(finalBonusScore);
            Console.WriteLine(finalBonusScore + input);
        }
        else
        {
            finalBonusScore = bonusScore + 5;
            Console.WriteLine(finalBonusScore);
            Console.WriteLine(finalBonusScore + input);
        }
    }
    }