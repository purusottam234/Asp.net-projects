using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_practice
{
    class Classmemberdemo
    {
        class Point1{
            private int x, y;
            public int X
            {
                get { return x; }
                set { x = value; }
            }
            public int Y
            {
                get { return y; }
                set { y = value; }
            }
            public void Show()
            {
                Console.WriteLine(" the value of x: " + x);
                Console.WriteLine("y: " + y);
            }
        }
        static void Main(string[] args)
        {
            Point1 a = new Point1();
            a.X = 10;
            a.Y = 30;
             
            Console.WriteLine("X: " + a.X);
            Console.WriteLine("Y: " + a.Y);
            Console.ReadKey();
        }
    }
}
