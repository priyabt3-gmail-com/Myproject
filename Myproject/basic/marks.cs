using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basic
{
    class marks
    {
        static void Main(string[] args)
        {
            int english = 87,marathi = 69,hindi=75,maths=80,history=73;
            float avg;
            avg = (english = marathi + hindi + maths + history) / 5;
            Console.WriteLine("Average of 5 marks are "+avg);
        }
    }
}
