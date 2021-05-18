using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet_Tutorial.InheritanceWithConstructor
{
    class Class_A
    {
        static Class_A()
        {
            Console.WriteLine("Static Constructor From Class AAAAAAAA");
        }
        public Class_A()
        {
            Console.WriteLine("I am From Base Or Parent Class");
        }
    }
}
