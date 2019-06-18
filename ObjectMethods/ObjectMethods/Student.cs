using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMethods
{
    class Student
    {
        public string name;
        public double gpa;

        public Student(string Oname, double Ogpa)
        {
            name = Oname;
            gpa = Ogpa;
        }
        
        public bool hasFirstClass()
        {
            double gpaLimit = 3.8;
            if (gpa > gpaLimit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
