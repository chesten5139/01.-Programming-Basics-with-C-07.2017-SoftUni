
using System;

class CurrencyConverter
{
    static void Main()
    {
        
        double BGN = 1;
        double USD = 1.79549;
        double EUR = 1.95583;
        double GBP = 2.53405;
        double currencyValue = double.Parse(Console.ReadLine());
        string inputCurrency = Console.ReadLine();
        string outputCurrency = Console.ReadLine();
        switch (inputCurrency)
        {
            case "BGN":
                break;
            case "USD":
                currencyValue = currencyValue * USD;
                break;
            case "EUR":
                currencyValue = currencyValue * EUR;
                break;
            case "GBP":
                currencyValue = currencyValue * GBP;
                break;
        }
        switch (outputCurrency)
        {
            case "BGN":
                currencyValue = currencyValue / BGN;
                break;
            case "USD":
                currencyValue = currencyValue / USD;
                break;
            case "EUR":
                currencyValue = currencyValue / EUR;
                break;
            case "GBP":
                currencyValue = currencyValue / GBP;
                break;
        }
        Console.WriteLine("{0} {1}", Math.Round(currencyValue, 2), outputCurrency);

        }
    }
    

/*
        using System;
        using System.Collections.Generic;
        using System.Linq;
        using System.Text;
        using System.Threading.Tasks;

class CurrencyConverter
    {
        static void Main()
        {
        double moneyToConvert = double.Parse(Console.ReadLine());
        string firstCurrency = Console.ReadLine();
        string secondCurrency = Console.ReadLine();
        Dictionary <string, double> currencies = new Dictionary <string, double>() { { "BGN", 1 }, { "USD", 1.79549 }, { "EUR", 1.95583 }, { "GBP", 2.53405 } };
        double result = moneyToConvert * (currencies[firstCurrency] / currencies[secondCurrency]);
        Console.WriteLine("{0} {1}", Math.Round(result, 2), secondCurrency);
    }

}
*/
