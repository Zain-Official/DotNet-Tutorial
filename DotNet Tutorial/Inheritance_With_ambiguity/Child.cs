using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet_Tutorial.Inheritance_With_ambiguity
{
    class Child : ParentClass
    {
        public void Display()
        {
            base.Display();
            Console.WriteLine("I am From Class Child");
        }
    }
}
