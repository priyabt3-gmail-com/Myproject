using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Btest
{
    class marks
    {
        
            static void Main(string[] args)
            {
                int english = 87, marathi = 69, hindi = 75, maths = 80, history = 73;
                float avg,per;
            int total;
            total = english = marathi + hindi + maths + history;
                Console.WriteLine("Total 5 marks are " + total);
            avg = (total) / 5;
                Console.WriteLine("Average of 5 marks are " + avg);
            per = (total / 500) * 100;
            Console.WriteLine("Percetage of 5 marks are " + avg);
        }
        

    }
}
