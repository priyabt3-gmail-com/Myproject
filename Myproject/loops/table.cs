using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.loops
{
    class table
    {
        static void Main(string[] args)
        {
            int i, num;

            Console.WriteLine("Enter number to print table: ");
            num = int.Parse(Console.ReadLine());
            for (i = 1; i <= 10; i++)
            {
                
                Console.WriteLine("{0} * {1} = {2}\n", num, i, (num * i));
            }
        }
    }
}
