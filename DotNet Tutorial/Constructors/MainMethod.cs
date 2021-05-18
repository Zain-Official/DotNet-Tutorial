using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet_Tutorial.Constructors
{
    class MainMethod
    {
        static MainMethod()
        {
            Console.WriteLine("Static Constructor");
        }
        MainMethod()
        {
            Console.WriteLine("Instance Constructor");
        }
        static void Main(string[] args)
        {
            MainMethod m = new MainMethod();
        }
    }
}
