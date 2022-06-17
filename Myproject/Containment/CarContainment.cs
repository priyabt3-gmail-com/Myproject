using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Containment
{
    
       
        class Engine
        {
            string type;

            public string Type
            {
                get { return type; }
                set { type = value; }
            }


        }



        class CarContainment
        {
            public int modelno;
            public string name;
            public int price;
            public Engine eng;

            public int Modelno
            {
                get;
                set;

            }
            public string Name
            {
                get;
                set;

            }
            public int Price
            {
                get;
                set;

            }
            public Engine Eng
            {
                get;
                set;
            }
            static void Main(string[] args)
            {
                CarContainment c = new CarContainment();
                c.Modelno = 2240;
                c.Name = "Audi";
                c.Price = 7900000;
                c.Eng = new Engine();
                c.Eng.Type = "CNG";
                Console.WriteLine(c.Modelno + " " + c.Name + " " + c.Price + " " + c.Eng.Type);
            }
        }
    

}

