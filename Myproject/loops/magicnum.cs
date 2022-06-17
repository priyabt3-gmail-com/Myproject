using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.loops
{
    class magicnum
    {
        static void Main(string[] args)
        {
            int magic_no = 50;

            for(; ; )
            {
                Console.WriteLine("Enter the no. ");
                int num = int.Parse(Console.ReadLine());

                if(num<magic_no)
                {
                    Console.WriteLine("No. is less than magic no pls try agin...");
                    continue;

                }
                else if(num>magic_no)
                {
                    Console.WriteLine("No. is greater than magic no pls try agin...");
                    continue;
                }
                else
                {
                    Console.WriteLine("Congratulation No. is Match...");
                    break;
                }
            }

        }
    }
}
