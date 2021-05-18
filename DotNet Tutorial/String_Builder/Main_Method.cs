using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet_Tutorial.PolyMorphism
{
    class Main_Method
    {
        static void Main(string[] args)
        {
            StringBuilder SB = new StringBuilder("WelCome To Dot Net Series......");
            Console.WriteLine(SB);
            SB.Append("Today We Discuss About StringBuilder");
            Console.WriteLine(SB);
            SB.Remove(5,6);
            Console.WriteLine(SB);
        }
    }
}
