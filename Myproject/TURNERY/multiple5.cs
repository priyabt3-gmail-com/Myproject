using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.TURNERY
{
    class multiple5
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter a Number : ");
            i = int.Parse(Console.ReadLine());
            string ans = (i % 5) == 0 ? "Number is multiple of 5" : " Number is not multiple of 5";

            Console.WriteLine(ans);
            
        }
    }
}
