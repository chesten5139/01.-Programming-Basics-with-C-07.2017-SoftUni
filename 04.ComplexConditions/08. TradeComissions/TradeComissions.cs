using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.TradeComissions
{
    class TradeComissions
    {
        static void Main()
        {
            string town = Console.ReadLine().ToLower();
            decimal salesVolume = decimal.Parse(Console.ReadLine());
            decimal commission = 0;

            if (town == "sofia")
            {
                if (salesVolume >= 0 && salesVolume <= 500)
                {
                    commission = 0.05m;
                    Console.WriteLine(salesVolume * commission);
                }
                else if (salesVolume > 500 && salesVolume <= 1000)
                {
                    commission = 0.07m;
                    Console.WriteLine(salesVolume * commission);
                }
                else if (salesVolume > 1000 && salesVolume <= 10000)
                {
                    commission = 0.08m;
                    Console.WriteLine(salesVolume * commission);
                }
                else if (salesVolume > 10000)
                {
                    commission = 0.12m;
                    Console.WriteLine(salesVolume * commission);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "varna")
            {
                if (salesVolume >= 0 && salesVolume <= 500)
                {
                    commission = 0.045m;
                    Console.WriteLine(salesVolume * commission);
                }
                else if (salesVolume > 500 && salesVolume <= 1000)
                {
                    commission = 0.075m;
                    Console.WriteLine(salesVolume * commission);
                }
                else if (salesVolume > 1000 && salesVolume <= 10000)
                {
                    commission = 0.10m;
                    Console.WriteLine(salesVolume * commission);
                }
                else if (salesVolume > 10000)
                {
                    commission = 0.13m;
                    Console.WriteLine(salesVolume * commission);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "plovdiv")
            {
                if (salesVolume >= 0 && salesVolume <= 500)
                {
                    commission = 0.055m;
                    Console.WriteLine(salesVolume * commission);
                }
                else if (salesVolume > 500 && salesVolume <= 1000)
                {
                    commission = 0.08m;
                    Console.WriteLine(salesVolume * commission);
                }
                else if (salesVolume > 1000 && salesVolume <= 10000)
                {
                    commission = 0.12m;
                    Console.WriteLine(salesVolume * commission);
                }
                else if (salesVolume > 10000)
                {
                    commission = 0.145m;
                    Console.WriteLine(salesVolume * commission);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (commission == 0)
            {
                Console.WriteLine("error");
            }

        }
    }
}
