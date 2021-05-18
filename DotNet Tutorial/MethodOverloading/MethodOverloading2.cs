using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet_Tutorial.MethodOverloading
{
    class MethodOverloading2
    {
        public int Sum()
        {
            return 5;
        }

        public int Sum(int x)
        {
            return x + 5;
        }

        public int Sum(int x,int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            MethodOverloading2 m = new MethodOverloading2();
            m.Sum();
            m.Sum(10);
            m.Sum(50, 50);

            Console.WriteLine(m.Sum());
            Console.WriteLine(m.Sum(10));
            Console.WriteLine(m.Sum(50,50));
        }
    }
}
