using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.conditions
{
    class withoutgreatest
    {
        static void Main(string[] args)
        {
            Console.Write("Enter three nos. ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("the largest no is " + num1);
                }
                else
                {
                    Console.Write("the largest no is " + num3);
                }
            }
            else if (num2 > num3)
            {
                Console.Write("the largest no is " + num2);
            }
            else
            {
                Console.Write("the largest no is " + num3);
            }
        }
    }
}
