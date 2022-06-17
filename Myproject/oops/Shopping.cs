using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.oops
{
    class Shopping
    {
        string item;
        int price,quantity,total;
        
        public void accept()
        {
            item = "Egg";
            price = 300;
            quantity = 2;

        }
        public void getbill()
        {
            if (quantity > 0)
            {
                total = price * quantity;
                //Console.WriteLine("Total price of the Product " + total);
                show();
            }
            else 
            {
                Console.WriteLine("You doesnt purchase any thing");
            }


        }
        public void show()
        {
            Console.WriteLine("***********************Receipt************************");
            Console.WriteLine("Item Name :  "+item);
            Console.WriteLine("Quantity  :  " + quantity);
            Console.WriteLine("Price     :  " + price);
            Console.WriteLine("\nTotal price of the Product " + total);
            Console.WriteLine("****************************************************");

        }


           

        static void Main(string[] args)
        {
            
            Shopping s = new Shopping();

            s.accept();
            s.getbill();
           // s.show();

        }
    }
}
