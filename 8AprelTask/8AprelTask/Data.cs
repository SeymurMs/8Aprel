using System;
using System.Collections.Generic;
using System.Text;

namespace _8AprelTask
{
    internal class Data
    {
        static Dictionary<string, double> _students = new Dictionary<string, double>();
        public static Dictionary<string, double> Students { get { return _students; } }
        public int No { get; set; }
        public Data(int no)
        {
            this.No = no;
        }
       
    }
}
