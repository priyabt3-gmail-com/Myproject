using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Btest
{
    class divisible
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number: ");
            int num = int.Parse(Console.ReadLine());


            if (num % 5 == 0 && num % 11 == 0)
            {
                Console.WriteLine("Divisible by 5 and 11 ");
            }
            else
            {
                Console.WriteLine("Not divisible by 5 and 11");
            }

        }
    }
}

