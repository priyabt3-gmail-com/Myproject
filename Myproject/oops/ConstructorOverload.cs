using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.oops
{
    class ConstructorOverload
    {


        
        ConstructorOverload()
            {
                Console.WriteLine("Car constructor");
            }

        
        ConstructorOverload(string brand,string color,int price)
            {
                Console.WriteLine("Car constructor with one parameter");
                Console.WriteLine("Brand: " + brand);
                Console.WriteLine("Color: " + color);
                Console.WriteLine("Price: " + price);
        }

            static void Main(string[] args)
            {

            
            ConstructorOverload car = new ConstructorOverload();

                Console.WriteLine();

            
            ConstructorOverload car2 = new ConstructorOverload("Bugatti","Blue", 113900000);

                Console.ReadLine();
            }
        
    }
}
