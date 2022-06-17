using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.oops
{
    
        class Student
        {
            public int id;
            public string name;
            public float per;
        public bool is_placed;

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

            public float Per
            {
                get { return per; }
                set { per = value; }
            }
            public bool Is_placed
        {

            get { return is_placed; }
            set { is_placed = value; }
        }

        }
        class StudProperty
        {
            static void Main(string[] args)
            {

            Student s = new Student();


                s.Id = 101;
                s.Name = "Amit";
                s.Per = 80.9f;
                s.Is_placed = true;
            Console.WriteLine(s.Id+" "+s.Name+" "+s.Per+" "+s.Is_placed);



            }



        }

    
}
