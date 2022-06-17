using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.conditions
{
    class vowels
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the character ");
            char ch = Console.ReadLine()[0];
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {

                Console.WriteLine("Vowels ");
            }
            else
            {
                Console.WriteLine("Consonants ");
            }

        }


        }
    }

    
