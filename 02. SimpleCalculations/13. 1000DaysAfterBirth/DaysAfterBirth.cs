using System;

namespace DaysAfterBirth
{
    class Program
    {
        static void Main()
        {
            /*
            DateTime date;
            if (DateTime.TryParse(Console.ReadLine(), out date))
            {
                Console.WriteLine(date.AddDays(999));
            }
            else
            {
                Console.WriteLine("Enter correct value");
            }
            */

            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
            DateTime d2 = date.AddDays(999);

            Console.WriteLine("{0:dd-MM-yyyy}", d2);

        }
    }
}
