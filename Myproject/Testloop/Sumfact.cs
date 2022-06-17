using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Testloop
{
    class Sumfact
    {
        static void Main(string[] args)
        {
            int i = 0, fact = 1, number;
            int sum=0;
            Console.Write("Enter any Number: ");
            number = int.Parse(Console.ReadLine());
           
            for (i = 1; i <= number; i++)

            {
                
               
                fact = fact * i;
                Console.WriteLine(+i + "! " +fact);
                sum += fact;

               
            }
           
            Console.WriteLine("\n Sum of all these no. are " + sum);



        }
    }
    
}
