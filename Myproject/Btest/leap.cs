﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Btest
{
    class leap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year : ");
            int Year = int.Parse(Console.ReadLine());

            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
            {
                Console.WriteLine("Leap Year.", +Year);
            }
            else
            {
                Console.WriteLine("Not a Leap Year.", +Year);

            }
        }
    }
}
