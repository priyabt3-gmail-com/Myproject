using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.loops
{
    class sumeven
    {
        static void Main(string[] args)
        {

            int sum = 0;
            for (int i = 0; i <= 30;i=i+2)
            {

                sum = sum + i;

           }

            Console.WriteLine("Sum of Even no.is {0}", sum);
        }
    }
}
