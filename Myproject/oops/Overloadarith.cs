using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.oops
{
    class Overloadarith
    {
        
            void arithmetic(int a, int b)
          
            {
                Console.WriteLine("Adition = "+(a+b));
            }
            void arithmetic(float a, float b)

            {
                Console.WriteLine("Subtraction = " + (a - b));
            }
            void arithmetic(int a, int b, int c)
            {
                Console.WriteLine("Multiplication = " + (a*b*c));
            }
        void arithmetic(double a, double b)
        {
            Console.WriteLine("Division = " + (a / b));
        }
        static void Main(string[] args)
        {
            Overloadarith m = new Overloadarith();
            m.arithmetic(10,20);
            m.arithmetic(5.5f, 2.5f);
            m.arithmetic(2,2,2);
            m.arithmetic(2.5, 1.5);


               
        }
}
}
