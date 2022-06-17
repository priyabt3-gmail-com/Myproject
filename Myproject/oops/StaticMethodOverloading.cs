using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.oops
{
    class StaticMethodOverloading
    {
        public class Test
        {
            static void foo()
            {
                Console.WriteLine("Test.foo() called ");
            }
            static void foo(int a)
            {
                Console.WriteLine("Test.foo(int) called ");
            }
            public static void main(String[] args)
            {
                Test.foo();
                Test.foo(10);
            }
        }
    }
}
