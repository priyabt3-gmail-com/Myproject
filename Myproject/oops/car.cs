using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.oops
{
    class car
    {
        public string car_name, color, car_model;
        public int price;


        static void Main(string[] args)
        {

            car c;
            c = new car();
            c.car_name = "BMW";
            c.car_model = "BMW X5";
            c.color = "red";
            c.price = 7900000;

            car c2;
            c2 = new car();
            c2.car_name = "Honda city";
            c2.car_model = "V 2020";
            c2.color = "Golden Brown";
            c2.price = 120000;

            car c3;
            c3 = new car();
            c3.car_name = "Maruti Suzuki";
            c3.car_model = "SWift";
            c3.color = "White";
            c3.price = 700000;

            Console.WriteLine("   Name             Model              Color           Price\n"); 
            Console.WriteLine("  " + c.car_name  + "\t            " + c.car_model  + "\t     " + c.color +    "\t     " + c.price);
            Console.WriteLine("  " + c2.car_name + "\t    " + c2.car_model + "\t   " + c2.color +   "\t     " + c2.price);
            Console.WriteLine("  " + c3.car_name + "\t    " + c3.car_model + "\t   " + c3.color +   "\t     " + c3.price);
        }
    }

    }
   