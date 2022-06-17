using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.oops
{
    class Employee
    {
        public int id;
        string name;
        float salary;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public float Salary
        {
            get { return salary; }
            set { salary = value; }
        }

    }
    class EmpProperty
    {
        static void Main(string[] args)
        {


            Employee c = new Employee();
            c.Id = 101;
            c.Name = "Priya";
            c.Salary = 40000;
            Console.WriteLine(c.Id+" "+c.Name+" "+c.Salary);

        }


    }

}
