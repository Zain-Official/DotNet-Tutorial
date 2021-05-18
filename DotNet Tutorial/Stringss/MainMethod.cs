using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet_Tutorial.Stringss
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            string s1 = "Zain Sindhi", s2 = "Haseeb", s3 = "Maroof Ali",s4="Zain Sindhi";
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(s3.GetHashCode());
            Console.WriteLine(s4.GetHashCode());
        }
    }
}
