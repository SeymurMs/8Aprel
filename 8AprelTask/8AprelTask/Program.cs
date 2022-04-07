using System;
using System.Collections;
using System.Collections.Generic;


namespace _8AprelTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            UserCRUD userCRUD = new UserCRUD();
            UserValidator userValidator = new UserValidator();
            bool check = true;
            
            do
            {
                Console.WriteLine("1. Telebe elave et");
                Console.WriteLine("2. Telebeye imtahan elave et");
                Console.WriteLine("3 .Telebenin bir imtahan balina bax");
                Console.WriteLine("4. Telebenin bütün imtahanlarini goster");
                Console.WriteLine("5. Telebenin imtahan ortalamasini goster");
                Console.WriteLine("6. Telebeden imtahan sil");
                Console.WriteLine("0. Proqrami bitir");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Telebenin adini daxil edin:");
                        string Fullname = Console.ReadLine();
                        bool isINt;
                        Console.WriteLine("Telebe No daxil edin:");
                        string noStr =Console.ReadLine();
                        int no;
                        isINt = int.TryParse(noStr, out no);
                        while (!isINt)
                        {
                            Console.WriteLine("Telebe No daxil edin:");
                            noStr = Console.ReadLine();
                            isINt = int.TryParse(noStr, out no);
                        }
                        students.Add(new Student(Fullname , no));
                        break;
                    case "2":
                                                
                        Console.WriteLine("Imtahan Adini Daxil edin");
                        string examName = Console.ReadLine();
                        while (!userValidator.CheckDictionary(examName))
                        {
                            Console.WriteLine("Bele Imtahan var Yeniden daxil edin:");
                            examName = Console.ReadLine();
                        }
                        double point;
                        Console.WriteLine("Qiymet daxil edin:");
                        string pointStr = Console.ReadLine();
                        bool isDouble;
                        isDouble = double.TryParse(pointStr, out point);
                        while (!isDouble)
                        {
                            Console.WriteLine("Qiymet daxil edin:");
                             pointStr = Console.ReadLine();
                            isDouble = double.TryParse(pointStr, out point);
                        }
                        userCRUD.AddExam(examName, point);
                            
                        break;
                    case "3":
                        Console.WriteLine("Axtardiginiz imtahani daxil edin:");
                        string searchExam = Console.ReadLine();
                        while (userValidator.CheckDictionary(searchExam))
                        {
                            Console.WriteLine("Imtahan adini duzgun daxil edin:");
                            searchExam = Console.ReadLine();
                        }
                        Console.WriteLine(userCRUD.GetExamResult(searchExam));
                        break;
                    case "4":
                        userCRUD.ShowInfo();
                        break;
                    case "5":
                        Console.WriteLine("Ortalamaniz:");
                        Console.WriteLine(userCRUD.GetExamAvg()); 
                        break;
                    case "6":
                        Console.WriteLine("Silmek istediyiniz Exami daxil edin:");
                        string removeExamName = Console.ReadLine();
                        userCRUD.RemoveExam(removeExamName);
                        break;
                    case "0":
                        check = false;
                        break;
                    default:
                        break;
                }
            } while (check);
        }
       
    }
}
