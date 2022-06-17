using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Btest
{
    class evenodd
    {
        static void Main(string[] args)
        {


            int i;
            Console.Write("Enter a Number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");

            }
            else
            {
                Console.Write("Entered Number is an Odd Number");

            }
        }
    }
}
