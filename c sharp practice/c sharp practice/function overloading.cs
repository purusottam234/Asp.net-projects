using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_practice
{
    class function_overloading
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Min:" + Min(10, 15));
            Console.WriteLine("Min: " + Min("Cow","Hen"));
        }
        static int Min(int n1, int n2)
        {
            if (n1 > n2)
                return n1;
            else
                return n2;

        }

        static string Min(string s1, string s2)
        {
            if (s1.CompareTo(s2) > 0)
            {
                return s1;
            }
            else
            {
                return s2;
            }
        }
    }
}
