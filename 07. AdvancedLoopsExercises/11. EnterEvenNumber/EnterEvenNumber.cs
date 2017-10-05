using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EnterEvenNumber
{
    class EnterEvenNumber
    {
        static void Main()
        {
            while (true)
            {
                try
                {
                    int num = int.Parse(Console.ReadLine());
                    if(num % 2 == 0)
                    {
                        Console.WriteLine("Even number entered: {0}", num);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The number is not even.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Number!");
                }
            }
        }
    }
}
