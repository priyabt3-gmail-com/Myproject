using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.oops
{
   class stud
    {
        public int id, php, java, html;
        public string name;
        public double ans;

        public void Accept()
        {
        id = 1001;
        php = 78;
        java = 87;
        html = 75;
        name = "Priya";
      
        }

        public double per()
        {
            ans = (php + java + html) / 3;
     
           

            return ans;
        }

        public void display()
        {
            Console.WriteLine("*****************************Student Details***************************************\n");
            Console.WriteLine("ID : " + id + "\nName : " + name);
            Console.WriteLine("\n");
            Console.WriteLine("\nSubject        Marks");
            Console.WriteLine("\nMarks of PHP :   " + php + "\nMarks of java :   " + java + "\nMarks of Html :   " + html);
            Console.WriteLine("\nPercentage "+ans+"%");
            Console.WriteLine("**********************************************************************************");
        }
    
        static void Main(string[] args)
        {
            stud s = new stud();
            s.Accept();
            s.per();
            s.display();
        }

    }
}
