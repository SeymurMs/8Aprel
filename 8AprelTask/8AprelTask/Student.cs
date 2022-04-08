using System;
using System.Collections.Generic;
using System.Text;

namespace _8AprelTask
{
    internal class Student
    {
        public Student(string fullName)
        {
            _no++;
            No = _no;
            
            this.Fullname = fullName;
        }

        static int _no;
        public int No { get; }
        public string Fullname { get; set; }        

    }
}
