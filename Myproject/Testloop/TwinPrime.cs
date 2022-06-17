using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Testloop
{
    class TwinPrime
    {
        static void Main(string[] args)
        {
            int n1, n2;
            int c = 0;
            Console.WriteLine("Enter 1st positive integer: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd positive integer: ");
            n2 = int.Parse(Console.ReadLine());



            for (int i = 1; i <= n1; i++)
            {
                
                    if (n1 % i == 0)
                {
                    c++;
                }
            }

            if (c == 2)
            {

                if (n2 == n1 + 2)
                {


                    Console.WriteLine("Twin prime no. {" + n1 + "," + n2+"}");
                }

                else
                {
                    Console.WriteLine("Not Twin prime no. {" + n1 + "," + n2 + "}");
                }

            }
           

        }
        
        
    }
}
