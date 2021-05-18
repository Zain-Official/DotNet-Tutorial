using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet_Tutorial.Extension_Method
{
    class Main_Method
    {
        static void Main(string[] args)
        {
            string s1 = "Wel Come Dotnet Programming......!";
            Console.WriteLine(s1);
            Console.WriteLine("Length Of String is "+s1.Length);

            Test.SayHello("hey");
        }
    }
}
