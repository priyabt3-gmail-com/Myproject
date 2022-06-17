using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.switchcase
{
    class days
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your Choice");
            int ch = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter first number ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number ");
            int b = int.Parse(Console.ReadLine());
           

            switch (ch)
            {
                case 1:
                    
                    Console.WriteLine("Monday ");
                    break;



                case 2:
                 
                    Console.WriteLine("Tuesday ");
                    break;

                case 3:
                   
                    Console.WriteLine("Wednesday ");
                    break;

                case 4:
                    
                    Console.WriteLine("Thursday ");
                    break;
                case 5:

                    Console.WriteLine("Friday ");
                    break;
                case 6:

                    Console.WriteLine("Saturay ");
                    break;
                case 7:

                    Console.WriteLine("Sunday ");
                    break;
               
                default:
                    Console.WriteLine("Invalid input");
                    break;

            }
        }
    }
}
