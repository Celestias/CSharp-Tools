using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prize
{
    class Student
    {
        string name;
        string course;

        public Student(string name, string course)
        {
            this.name = name;
            this.course = course;
        }

        public string getName()
        {
            return name;
        }

        public string getCourse()
        {
            return course;
        }

    }
}
