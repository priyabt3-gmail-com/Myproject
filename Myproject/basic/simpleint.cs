using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.basic
{
    class simpleint
    {
        static void Main(string[] args)
        {
            double principl_amt=50000, interest_rate=9.5, yeas=5, si;
            si = (principl_amt * interest_rate * yeas) / 100;
            Console.WriteLine("Simple Interest is "+si);
        }
    }
}
