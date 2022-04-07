using System;
using System.Collections.Generic;
using System.Text;

namespace _8AprelTask
{
    internal class UserValidator
    {
        public bool CheckDictionary(string exam)
        {
            if (Data.Students.ContainsKey(exam))
            {
                return false;
            }
            return true;
        }
        
    }
}
