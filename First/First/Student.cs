using System;
using System.Collections.Generic;
using System.Text;

namespace First
{
    class Student
    {
        public string name;
        public string pamoka;
        public double grade;

        public Student(string aName, string aPamoka, double agrade)
        {
            name = aName;
            pamoka = aPamoka;
            grade = agrade;

        }
        public bool HasHonors()
        {
            if (grade >= 3.5)
            {
                return true;
            }else
            {

            }
            return false;
        }
    }
}
