using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.conditions
{
    class teenager
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the age \n");
            int age = int.Parse(Console.ReadLine());
            
            if(age>=13 && age<=17)
            {
                Console.WriteLine("You are Teenager");
            }
            else
            {
                Console.WriteLine("You are not Teenager");
            }
        }
    }
}
