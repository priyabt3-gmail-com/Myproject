using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.conditions
{
    class multiple5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the age \n");
            int number = int.Parse(Console.ReadLine());
            if ((number % 5) == 0)
            {
                Console.WriteLine(" Number is multiple of 5\n");
            }
            else
            {
                Console.WriteLine(" Number is not multiple of 5\n");
            }
        }
    }
}
