using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Testloop
{
    class spy
    {
        static void Main(string[] args)
        {
            int num, product = 1, sum = 0, lastdigit;

            //Scanner sc = new Scanner(System.in);
            Console.WriteLine("Enter the number to check: ");

            num = int.Parse(Console.ReadLine());
           
            while (num > 0)
            {
                lastdigit = num % 10;
                sum = sum + lastdigit;
                product = product * lastdigit;
                num = num / 10;
            }
            
            if (sum == product)
                Console.WriteLine("The given number is a spy number.");
                else
                Console.WriteLine("The given number is not a spy number.");
        }
    }
}
    

