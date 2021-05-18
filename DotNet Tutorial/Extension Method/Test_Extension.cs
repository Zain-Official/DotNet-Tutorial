using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet_Tutorial.Extension_Method
{
   static class Test_Extension
    {
        public static int Mult(this Demo obj,int x, int y)
        {
            return x + y;   
        }
    }
}
