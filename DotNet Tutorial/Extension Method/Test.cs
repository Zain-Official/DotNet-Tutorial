using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet_Tutorial.Extension_Method
{
    static class Test
    {
        public static string SayHello(this string s)
        {
            return "Good Morning Pakistan";
        }
    }
}
