
using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basic
{
    class equtriangle
    {
        static void Main(string[] args)
        {

            int side = 3;
            double area;
            Console.WriteLine("side is " + side);
            area = (1.732 / 4) * (side * side);
            Console.WriteLine("area is " + area);
        }
    }
}
