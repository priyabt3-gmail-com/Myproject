using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.conditions
{
    class fndage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age \n");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter friends age \n");
            int fage = int.Parse(Console.ReadLine());

            if (fage > age)
            {
                Console.WriteLine("Hii");
            }
            else if (age > fage)
            {
                Console.WriteLine("Good morning");
            }

            else
            {
                Console.WriteLine("How are you?");
            }
        }
    }
}
