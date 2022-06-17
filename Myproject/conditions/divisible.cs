using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.conditions
{
    class divisible
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number: ");
            int num = int.Parse(Console.ReadLine());


            if (num % 10 == 0 )
            {
                Console.WriteLine("Divisible by 10 ");
            }
            else
            {
                Console.WriteLine("Not divisible by 10");
            }
            
        }
    }
}
