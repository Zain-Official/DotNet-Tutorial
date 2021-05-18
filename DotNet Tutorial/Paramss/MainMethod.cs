using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet_Tutorial.Paramss
{
    class MainMethod
    {
        public void Show(params string[] name)
        {
            foreach(string s in name)
            {
                Console.WriteLine(s + " ");
            }
        }
        static void Main(string[] args)
        {
            MainMethod m = new MainMethod();
            m.Show();
            m.Show("Zain Sindhi");
            m.Show("Haseeb", "Mehtab Ali");
            m.Show("Zain Sindhi", "Qayoom", "Hafeez");
        }
    }
}
