using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.loops
{
    class power
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the exponent ");
            int e = int.Parse(Console.ReadLine());

            int power = 1;
            for (int i = 1; i <= e; i++)
            {
                power = power * b;
            }
            Console.WriteLine("Power is "+power);
        }
    }
}
