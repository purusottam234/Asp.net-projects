using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_practice
{
    class student
    {
        private int roll;
        public int Roll
        {
            get { return roll; }
            set { roll = value; }
        }
        private int[] marks = new int[3];
        public int this[int index]
        {
            get { return marks[index]; }
            set { marks[index] = value; }
        }
        public double getpercentage()
        {
            double total = 0.0;
            foreach (int m in marks)
            {
                total = total + m;
            }
            return total / marks.Length;
        }
    }
    static void Main(String[] args)
    {
        student s1 = new student();
        s1.Roll = 1;
        s1[0] = 10;
        s1[1] = 10;
        s1[2] = 40;
        Console.WriteLine(s1.getpercentage());
    
    }
}

    


