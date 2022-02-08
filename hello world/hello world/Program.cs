using System;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Tika i love you");
            string str = "welcome home";
            if (str.Length > 0)
                Console.WriteLine("length is >0");
            else
                Console.WriteLine("length is <0");
            Console.ReadKey();
        }
    }
}
