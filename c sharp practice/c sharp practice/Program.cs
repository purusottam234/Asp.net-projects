using System;

namespace c_sharp_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            f1();
            int a = square(10);
            Console.WriteLine(a);
        }
        static void f1()
        {
            Console.WriteLine("We are executing f1");
        }
        static int square(int n)
        {
            return n * n;
        }
    }
}
