using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.TURNERY
{
    class evenodd
    {
        static void Main(string[] args)
        {


            int i;
            Console.Write("Enter a Number : ");
            i = int.Parse(Console.ReadLine());
            string ans = i % 2 == 0 ? "Number is an Even Number" : " Number is an Odd Number";

            Console.WriteLine(ans);
        }
    }
}
