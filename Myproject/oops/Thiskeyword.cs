using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.oops
{
    class Thiskeyword
    {
        int eid;
        string ename;
        double esalary;
        public Thiskeyword(int eid, string ename, double esalary)
        {
            this.eid = eid;
            this.ename = ename;
            this.esalary = esalary;
            
        }

        public Thiskeyword():this(101, "Priya",3.3)
        {

            Console.WriteLine("Emp id     " +eid);
            Console.WriteLine("Emp name   " +ename);
            Console.WriteLine("Emp salary " + esalary);


        }
        public void getgrade()
        {
            if (esalary > 5.5)
            {
                Console.WriteLine("Grade A");
            }
            else
            {
                Console.WriteLine("Grade B");
            }

        }
        
        static void Main(string[] args)
        {
            Thiskeyword t = new Thiskeyword();
            t.getgrade();
        }
    }
}
