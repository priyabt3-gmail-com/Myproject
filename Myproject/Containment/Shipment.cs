using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Containment
{
    class Shipment
    {
        int sid;
        public Order order1;

        public int Sid
        {
            get;
            set;
        }
        public Order Order1
        {
            get;
            set;
        }
        static void Main(string[] args)
        {
            Shipment s = new Shipment();
            s.Sid = 1;
            Order o = new Order();
            s.Order1 = o;
            s.Order1.Order_id = 101;
            s.Order1.Cust_name = "Amit";
            s.Order1.City = "Pune";
            s.Order1.Odate = new Order_date();
            s.Order1.Odate.Dd = 12;
            s.Order1.Odate.Mm = 02;
            s.Order1.Odate.Yy = 20;

            Console.WriteLine("Shpment id " + s.Sid + "\n Order Id  " + s.Order1.Order_id + "\nCustomer name  " + s.Order1.Cust_name + "\n Customer city  " + s.Order1.City + "\n Order date  " + s.Order1.Odate.Dd + "/" + s.Order1.Odate.Mm + "/" + s.Order1.Odate.Yy);
        }
    }
    }


    class Order
    {
        int order_id;
        string cust_name,city;

        public Order_date odate;
        public int Order_id
        {
            get;
            set;
        }
        public string Cust_name
        {
            get;
            set;
        }

        public string City
        {
            get;
            set;
        }

        public Order_date Odate
        {
            get;
            set;
        }
    }
    class Order_date
    {
        int dd, mm, yy;
   
    public int Dd
        {
            get;
            set;
        }
        public int Mm
        {
            get;
            set;
        }
        public int Yy
        {
            get;
            set;
        }



    }






