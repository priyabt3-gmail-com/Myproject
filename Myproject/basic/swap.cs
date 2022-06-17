using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basic
{
    class swap
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 5;
            Console.WriteLine("value of a is "+a);
            Console.WriteLine("value of b is " + b);
            
            a = a+b;//a=7
            b = a-b;//b=2
            a = a-b;//a=5
            Console.WriteLine("After swaping value of a is "+a);
            Console.WriteLine("After swaping value of a is " + b);
        }
    }
}
