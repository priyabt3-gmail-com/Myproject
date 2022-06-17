using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.conditions
{
    class marksgrade
    {
        static void Main(string[] args)
        {
            int english, marathi,hindi,maths,history;
            Console.WriteLine("Enter the marks of all 5 Subjects\n");
            english=int.Parse(Console.ReadLine());
            marathi = int.Parse(Console.ReadLine());
            hindi = int.Parse(Console.ReadLine());
            history = int.Parse(Console.ReadLine());
            maths = int.Parse(Console.ReadLine());
            float avg;
            avg = (english + marathi + hindi + maths + history) / 5;
            Console.WriteLine("Average of 5 marks are " + avg);

            if (avg >= 70 && avg <= 100)
            {
                Console.WriteLine("Distinction");
            }
            else if (avg >= 60 && avg <= 69)
            {
                Console.WriteLine("First Class");
            }
            else if (avg >= 50 && avg <= 59)
            {
                Console.WriteLine("second Class");
            }
            else if (avg >= 40 && avg <= 49)
            {
                Console.WriteLine("Third Class");
            }

        }
    }
}
