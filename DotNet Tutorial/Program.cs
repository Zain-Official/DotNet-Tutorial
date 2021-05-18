using System;

namespace DotNet_Tutorial
{
    class Program
    {
        int n;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.n = 12;
            Program p2 = new Program();
            p2.n = 13;

            Console.WriteLine(p.n);
            Console.WriteLine(p.GetHashCode());
            Console.WriteLine("\n**************\n");
            Console.WriteLine(p2.n);
            Console.WriteLine(p2.GetHashCode());



            Console.ReadKey();
        }
    }
}
