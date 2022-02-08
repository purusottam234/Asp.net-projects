using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_practice
{
    class inheritancedemo
    {
            public class ParentClass
        {
            public ParentClass()
            {
                Console.WriteLine("This is the parent class");

            }
             public void print()
             {
                 Console.WriteLine("This is the Parent");
             }
        }
        public class ChildClass: ParentClass
        {
            public ChildClass()
            {
                Console.WriteLine("I am the Parent constructor");
            }
        }
        static void Main(string[] args)
        {
            ChildClass cc = new ChildClass();
            cc.print();
        }
    }
}

