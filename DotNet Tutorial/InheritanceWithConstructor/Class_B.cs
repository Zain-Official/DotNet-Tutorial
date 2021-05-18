using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet_Tutorial.InheritanceWithConstructor
{
    class Class_B : Class_A
    {
        static Class_B()
        {
            Console.WriteLine("\nStatic Constructor From Class B \n");
        }
        public Class_B()
        {
            Console.WriteLine("I am From Child or Derived Class ");
        }
    }
}
