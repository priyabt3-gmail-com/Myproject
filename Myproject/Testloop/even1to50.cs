using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Testloop
{
    class even1to50
    {
        static void Main(string[] args)
        {
            int i;
            //int s = 0;

            for (i = 1; i <= 50; i++)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine("\n "+i+" IS Even");
                }


                else if(i%2!=0)
                {
                    int s = i * i;
                    Console.WriteLine("\n"+i+" Odd no. and the square is : "+s);

                }
            }
        }
    }
}

