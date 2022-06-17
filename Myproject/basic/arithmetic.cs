using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basic
{
    class arithmetic
    {
        static void Main(string[] args)
        {
            int a = 4, b = 2, result;
            Console.WriteLine("Value of a is "+a);
            Console.WriteLine("Value of b is " + b);
            result = a + b;
            Console.WriteLine("Adiition of a and b is         "+result);
            result = a - b;
            Console.WriteLine("Subtraction of a and b is      " + result);
            result = a * b;
            Console.WriteLine("Multiplication of a and b is   " + result);
            result = a / b;
            Console.WriteLine("Division of a and b is         " + result);
            result = a % b;
            Console.WriteLine("Modulas of a and b is          " + result);
        }
    }
}
