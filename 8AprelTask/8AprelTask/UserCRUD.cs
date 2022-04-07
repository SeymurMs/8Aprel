using System;
using System.Collections.Generic;
using System.Text;

namespace _8AprelTask
{
    internal class UserCRUD
    {
        
        public void AddExam(string examName, double point)
        {
            
            Data.Students.Add(examName,point);
        }
        public double GetExamResult(string examName)
        {
            return Data.Students.GetValueOrDefault(examName);
        }
        public double GetExamAvg()
        {
            double total = 0;
            foreach (var item in Data.Students)
            {
                total += item.Value;
            }
            total /= Data.Students.Count;
            return total;
        }
        public void RemoveExam(string examName)
        {
            Data.Students.Remove(examName);
        }
        public void ShowInfo()
        {
            foreach (var s in Data.Students)
            {
                Console.WriteLine("Exam = {0}", s);
            }
        }
    }
}
