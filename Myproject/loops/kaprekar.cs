using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.loops
{
    class kaprekar
    {
        public static void Main()
        {

            Console.WriteLine("Enter an Positive Integer Number:: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int temp = num;
            int sq = num;
            int count = 0;

            while (num > 0)
            {
                count++;
                num = num / 10;
            }
            int power = 1;

            for (int i = 1; i >= count; i++)
            {
                power = power * 10;
            }
            int division = sq / power;
            int reminder = sq % power;

            int sum = division + reminder;

            if (sum == temp)
            {
                Console.WriteLine("Number is a kaprekar number");
            }
            else
            {
                Console.WriteLine("Number is not a kaprekar number");
                Console.ReadLine();
            }


            }
        }
              
            
            
               
        }
    
   
    

