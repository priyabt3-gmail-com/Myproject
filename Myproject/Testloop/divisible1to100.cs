using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Testloop
{
    class divisible1to100
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 5 == 0 && i % 10 == 0))
                {
                    Console.WriteLine(i);

                }

            }
        }
    }
}
