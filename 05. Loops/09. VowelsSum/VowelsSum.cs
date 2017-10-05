using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.VowelsSum
{
    class VowelsSum
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int stringLenght = input.Length;
            int sum = 0;
            for (int i = 1; i <= stringLenght; i++)
            {
                char x = input[i-1];
                switch (x)
                {
                    case 'a':
                        sum += 1; 
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;

                }
            }
            Console.WriteLine(sum);
        }
    }
}
