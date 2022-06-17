using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Btest
{
    class Class1
    {
       
            static void Main(String[] args)
            {
                int a = 5, b = 4, c = 3;
                Console.WriteLine(a++ + b * ++c);
                Console.WriteLine("a = " + a + " b= " + b + " c = " + c);
                Console.WriteLine(b * 5 / a + b++ + b);
                Console.WriteLine("a = " + a + " b= " + b + " c = " + c);
            }
        
    }
    
}
