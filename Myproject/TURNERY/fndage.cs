using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.TURNERY
{
    class fndage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age \n");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter friends age \n");
            int fage = int.Parse(Console.ReadLine());

            string ans = fage > age ? "Hii" : age > fage ? "Good Morning" : "how are you";
            Console.WriteLine(ans);
            }
    }
}
