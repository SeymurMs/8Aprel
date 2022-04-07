using System;
using System.Collections.Generic;
using System.Text;

namespace _8AprelTask
{
    internal class Student
    {
        public Student(string fullName, int no)
        {
            this.No = no;
            this.Fullname = fullName;
        }

        public int No { get; set; }
        public string Fullname { get; set; }        

    }
}
