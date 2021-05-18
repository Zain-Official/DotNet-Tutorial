using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet_Tutorial.StaticVariable
{
    class Cricket
    {
        static int score;
        public void Incr(int x)
        {
            score += x;
        }
        static void Main(string[] args)
        {
            Cricket fb = new Cricket();
            Cricket sb = new Cricket();
            Cricket ext = new Cricket();
            fb.Incr(12);
            sb.Incr(15);
            ext.Incr(8);

           Console.WriteLine("Total Score is "+score);

        }
    }
}
