using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Testloop
{
    class PrintSeries
    {
        static void Main(string[] args)
        {
            
                int n=10;
            int a=0;
            for (int i = 1; i <= n; i++)
            {
                a = (i * i) + (i * i * i);
                Console.WriteLine(a + " ");
            }
        }
    }
}
