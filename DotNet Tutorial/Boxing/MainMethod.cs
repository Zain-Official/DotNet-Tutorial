using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet_Tutorial.Boxing
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            int x = 12;
            double y = 12.4;
            string name = "Zain Sindhi";

            /*  Boxing */
            object obj1 = x;
            object obj2 = y;
            object obj3 = name;

            /*UnBoxing */

            int x1 = (Int32)obj1;
            double y1 = (Double)obj2;
            string s1=(string)obj3
        }
    }
}
