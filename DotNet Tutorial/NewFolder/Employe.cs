using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet_Tutorial.NewFolder
{
    class Employe
    {
        int empno;
        string name;
        double salary;

        public override string ToString()
        {
            return "Employ No: " + empno + "\nName: " + name + "\nSalary: " + salary;
        }

        static void Main(string[] args)
        {
            Employe e = new Employe();
            e.empno = 121;
            e.name = "Zain Sindhi";
            e.salary = 5000.0;
            Console.WriteLine(e);
        }
    }
}
