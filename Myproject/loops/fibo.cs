using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.loops
{
    class fibo
    {
        static void Main(string[] args)
        {
            int val1 = 0, val2 = 1, val3, i;
            Console.WriteLine("Enter the no. ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Fibonacci series:");
            Console.Write(val1 + " " + val2 + " ");
            for (i = 2; i < n; ++i)
            {
                val3 = val1 + val2;
                Console.Write(val3 + " ");
                val1 = val2;
                val2 = val3;
            }
        }
    }
    
}
