using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_practice
{

    class point
    {
        public int x, y;
        public void Show()
        {
            Console.WriteLine("x:" +x);
            Console.WriteLine("y:" + y);
        }
          
    }
    class Classdemotesting
    {
        static void Main(string[] args)
        {
            point a = new point();
            a.x = 10;
            a.y = 20;
            a.Show();
            Console.ReadKey();


        }

    }
}
