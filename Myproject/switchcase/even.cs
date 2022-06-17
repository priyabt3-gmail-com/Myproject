using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.switchcase
{
    class even
    {
        static void Main(string[] args)
        {

        
        Console.WriteLine("Enter your Choice");
            int ch = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number ");
            int a = int.Parse(Console.ReadLine());
        
        

            switch (ch)
            {
                case 1:
                    if (a %2==0)
                    Console.WriteLine("Even");
                    break;

                default:
                    Console.WriteLine("Odd");
                    break;

            }

}
    }
    }

