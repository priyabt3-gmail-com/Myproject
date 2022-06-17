using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Inheritance
{
    class Person
    { 
    public String name = "John";
    public int age = 17;
    public String city = "Delhi";
    public void show()
    {
            Console.WriteLine("Student inheriting properties from Person:\n");
    }
    }

    class Student : Person
    {

        public int marks = 78;
        public String tutorial = "TechVidvan Tutorial of Java";
    }



    class SingleInheritance1
    {
        static void Main(string[] args)
        {
            Student obj = new Student();
            obj.show();
            Console.WriteLine("Name of the student is: " + obj.name);
            Console.WriteLine("Age of the student is: " + obj.age);
            Console.WriteLine("Student lives in: " + obj.city);
            Console.WriteLine("Student learns from: " + obj.tutorial);
            Console.WriteLine("Marks obtained by the student is: " + obj.marks);
        }
    }
}
