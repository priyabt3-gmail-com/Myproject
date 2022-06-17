using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.loops
{
    class Pattern1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                   Console.Write(j);
                }
                Console.WriteLine();
                for (int k = i; k > 0; k--)
                {
                   
                }
            }
        }
     
    }
}
