using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Containment
{
    class Bag
    {
        string color, brand;
        int price;
        public Pen penn;

        public int Price
        {
            get;
            set;
        }
        public string Color
        {
            get;
            set;
        }
        public string Brand
        {
            get;
            set;
        }
        public Pen Penn
        {
            get;
            set;
        }

        static void Main(string[] args)
        {
            Bag b = new Bag();
            b.Color = "Blue";
            b.Brand = "Skybag";
            b.Price = 1500;
            Pen p = new Pen();
            b.Penn = p;
            b.Penn.Pname = "Lexi";
            b.Penn.Pcolor = "black";
            b.Penn.N = new Nib();
            b.Penn.N.Ntype = "Plastic";
            Console.WriteLine(" "+b.Color+" "+b.Brand+" "+b.Price+" "+b.Penn+" "+b.Penn.Pname+" "+b.Penn.Pcolor+" "+b.Penn.N.Ntype);
        }    
    }
    class Pen
    {
        string pname, pcolor;
        public Nib n;
        
        public string Pcolor
        {
            get;
            set;
        }
        public string Pname
        {
            get;
            set;
        }
        public Nib N
        {
            get;
            set;
        }
    }

    class Nib
    {
        string ntype;
        public string Ntype
        {
            get;
            set;
        }
    }
}
