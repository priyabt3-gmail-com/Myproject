﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Testloop
{
    class Pat1
    {
        static void Main(string[] args)
        {
            for (int i = 1, l = 4, m = 1; i <= 9; i += 2, l--, m++)
            {
                for (int j = 1; j < l; j++)
                    Console.WriteLine(" ");
                for (int k = 1; k <=i; k++)
                    Console.Write(m);
                Console.WriteLine();
            }
        }
    }
}
