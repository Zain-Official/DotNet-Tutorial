using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet_Tutorial.Base_Constructor
{
    class Employe
    {
        int empno;
        string name;
        double basics;
        public Employe(int EmpNo,string Name,double Basics)
        {
            this.empno = EmpNo;
            this.name = Name;
            this.basics = Basics;
        }

        public override string ToString()
        {
            return "Employe No: "+empno+"\nName: "+name+"\nBasics: "+basics;
        }
    }
}
