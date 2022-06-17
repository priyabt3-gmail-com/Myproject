using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.TURNERY
{
    class greatest
    {
        static void Main(string[] args)
        {
            Console.Write("Enter three nos. ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int ans= (n1 > n2) ? n1 > n3 ? n1 : n3 : n2 >n3 ? n2 : n3;
            Console.WriteLine(ans);

        }
    }
}

