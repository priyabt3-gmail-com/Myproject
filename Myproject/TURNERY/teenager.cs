using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.TURNERY
{
    class teenager
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter the age \n");
            int age = int.Parse(Console.ReadLine());

            string ans = (age >= 13) && age <= 17 ? "You are Teenager" : "You are not Teenager";
            Console.WriteLine(ans);
      }
    }
}
