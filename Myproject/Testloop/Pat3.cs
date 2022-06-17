using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Testloop
{
    class Pat3
    {
        static void Main(string[] args)
        {

            int i, j;
            int MAX = 5;

            for (i = MAX; i >= 1; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }

    }
    }



    

