using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Btest
{
    class Max3
    {

        static void Main(string[] args)
        {
            Console.Write("Enter three nos. ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {

                Console.WriteLine("The largest no is " + num1);
            }

            else if (num2 > num3 && num2 > num3)
            {
                Console.WriteLine("the largest no is " + num2);
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("the largest no is " + num3);
            }
        }
    }
}
