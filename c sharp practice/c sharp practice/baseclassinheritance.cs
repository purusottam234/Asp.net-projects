using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_practice
{
    class baseclassinheritance
    {

        public class ParentClass
        {
            public int x = 10;
            public ParentClass()
            {
                Console.WriteLine("I am parent class");

            }
            public void Print()
            {
                Console.WriteLine("Parent class");
            }
        }


        public class ChildClass : ParentClass
        {
            public ChildClass() : base()
            {
                Console.WriteLine("Child constructor");
                base.Print();
                Console.WriteLine(base.x);

            }
        }




        static void Main(string[] args)
        {
            ChildClass a = new ChildClass();
            a.Print();
            Console.ReadKey();
        }
    }
}
