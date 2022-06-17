using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Containment
{
    class StaticClass
    {
        
            static void Main(string[] args)
            {
                sClass.printMethod();
                Console.WriteLine(sClass.num1 + sClass.num2);
                Console.ReadLine();
            }
        }
        static class sClass
        {
            public static int num1;
            public static int num2;
            static sClass()
            {
                num1 = 5;
                num2 = 10;
                Console.WriteLine("Addition");
            }
            public static void printMethod()
            {

                Console.WriteLine("Static print method");
            }
        }
    
}
