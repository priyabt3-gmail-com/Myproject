using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Btest
{
    class calulator
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Various Arithmetic Operations\n");
            Console.WriteLine("Enter 1 for Addition\n");
            Console.WriteLine("Enter 2 Substraction\n");
            Console.WriteLine("Enter 3 for Multiplicatin\n");
            Console.WriteLine("Enter 4 Division\n");

            Console.WriteLine("Enter your Choice");
            int ch = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter first number ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number ");
            int b = int.Parse(Console.ReadLine());
            int c;

            switch (ch)
            {
                case 1:
                    c = a + b;
                    Console.WriteLine("Addtion = " + c);
                    break;



                case 2:
                    c = a - b;
                    Console.WriteLine("Subtraction = " + c);
                    break;

                case 3:
                    c = a * b;
                    Console.WriteLine("Multiplication = " + c);
                    break;

                case 4:
                    c = a / b;
                    Console.WriteLine("Division = " + c);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;

            }

        }
    }
}
