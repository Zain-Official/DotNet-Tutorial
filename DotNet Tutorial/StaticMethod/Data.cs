using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet_Tutorial.StaticMethod
{
    class Data
    {
        public Data()
        {

        }
        public void Show()
        {
            Console.WriteLine("Show Method From Data Class");
        }

        public static void Display()
        {
            Console.WriteLine("Display Method From Data Class");
        }

    }
}
