using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet_Tutorial.Constructors
{
    class DefaultConstructor
    {
        int empno;
        string name;
        double salary;
        public DefaultConstructor()
        {
            this.empno = 1;
            this.name = "Balaj Khan";
            this.salary = 1200;
        }

        public DefaultConstructor(int EmpNo,string Name,double Salary)
        {
            this.empno = EmpNo;
            this.name = Name;
            this.salary = Salary;
        }

        public override string ToString()
        {
            return "Employe No: " + empno + "\nName: " + name + "\nSalary: " + salary;
        }
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(" Wel Come To Dot Net Series");
            sb.Insert(0,"Hello World");
            Console.WriteLine(sb);
            DefaultConstructor dc = new DefaultConstructor();
            Console.WriteLine(dc);
            Console.WriteLine("\n*******************\n");
            DefaultConstructor DC = new DefaultConstructor(120,"Haseeb",7000.0);
            Console.WriteLine(DC);


        }
    }
}
