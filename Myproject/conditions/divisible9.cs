using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.conditions
{
    class divisible9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number: ");
            int num = int.Parse(Console.ReadLine());


            if (num % 3 == 0 && num % 9 == 0)
            {
                Console.WriteLine("Divisible by 3 oand 9 ");
            }
            else
            {
                Console.WriteLine("Not divisible by 3 and 9");
            }
            
        }
    }
}
