using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.loops
{
    class prime
    {
        static void Main(string[] args)
        {
            int n, a = 0;
            Console.WriteLine("Enter the no. ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine("{0} is a Prime Number", n);
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
            Console.ReadLine();
        }
    }
}
