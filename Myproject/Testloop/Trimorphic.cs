using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Testloop
{
    class Trimorphic
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number:");
            num = int.Parse(Console.ReadLine());
            int flag = 0;
            int cube_power = num * num * num;
            while (num != 0)
            {
                if (num % 10 != cube_power % 10)
                {
                    flag = 1;
                    break;
                }
                num /= 10;
                cube_power /= 10;
            }
            if (flag == 0)
                Console.WriteLine("It is a Trimorphic Number.");
            else
                Console.WriteLine("It is not a Trimorphic Number.");
        }
    }
    
}
