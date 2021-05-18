using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet_Tutorial.MethodOverloading
{
    class Main_Method
    {
        public void Show(int x)
        {
            Console.WriteLine("Show Method w.r.t Interger "+x);
        }

        public void Show(double x)
        {
            Console.WriteLine("Show Method w.r.t Double " + x);
        }

        public void Show(string x)
        {
            Console.WriteLine("Show Method w.r.t String " + x);
        }

      
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Number");
            int x = Convert.ToInt32(Console.ReadLine());
            Main_Method m = new Main_Method();
            m.Show(x);
            m.Show(23.5);
            m.Show("Zain Sindhi");
        }
    }
}
