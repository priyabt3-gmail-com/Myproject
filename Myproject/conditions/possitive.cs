using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.conditions
{
    class possitive
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the no. ");
            n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                Console.WriteLine("Possitive ");

            }
            else if (n < 0)
            {
                Console.WriteLine("Negative");

            }
            else
            {
                Console.WriteLine("zero");
            }
        }

    }
}
