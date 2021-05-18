using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet_Tutorial.StaticMethod
{
    class Main_Method
    {
        static void Main(string[] args)
        {
            Data d = new Data();
            d.Show();
            Data.Display();
        }
    }
}
