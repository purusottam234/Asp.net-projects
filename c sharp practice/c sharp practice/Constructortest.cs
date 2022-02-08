using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_practice
{
    class Constructortest
    {

        class point2
        {
            public int x, y;
            public point2() { } //default constructor
            public point2(int x, int y) //parametrized constructor
            {
                this.x = x;
                this.y = y;
            }
        }
        static void Main(string[] args)
        {
            point2 b = new point2();
            b.x = 11;
            b.y = 12;
            point2 c = new point2(2, 5);
            Console.WriteLine("the value of x is " + b.x);
            Console.WriteLine("the value of y is " + b.y);

        }
    }
}
