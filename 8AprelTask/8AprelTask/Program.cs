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
                        students.Add(new Student(Fullname));
                        break;
                    case "2":
                        int no = CheckInt("No degeri daxil edin:", "No degeri duzgun daxil edin:");
                        if (students.Exists(x => x.No == no))
                        {
                            Console.WriteLine("Imtahan Adini Daxil edin");
                            string examName = Console.ReadLine();
                            while (!userValidator.CheckDictionary(examName))
                            {
                                Console.WriteLine("Bele Imtahan var Yeniden daxil edin:");
                                examName = Console.ReadLine();
                            }
                            double point = CheckDouble("Qiymeti daxil edin:", "Qiymeti duzgun daxil edin");
                            userCRUD.AddExam(examName, point);
                        }
                        else
                            Console.WriteLine("Bele bir no yoxdur!!");
                        break;
                    case "3":
                        no = CheckInt("No degeri daxil edin:", "No degeri duzgun daxil edin:");
                        if (students.Exists(x => x.No == no))
                        {
                            Console.WriteLine("Axtardiginiz imtahani daxil edin:");
                            string searchExam = Console.ReadLine();
                            while (userValidator.CheckDictionary(searchExam))
                            {
                                Console.WriteLine("Imtahan adini duzgun daxil edin:");
                                searchExam = Console.ReadLine();
                            }
                            Console.WriteLine(userCRUD.GetExamResult(searchExam));
                            break;
                        }
                        else
                            Console.WriteLine("Bele bir no yoxdur!!");
                        break;
                    case "4":
                        no = CheckInt("No degeri daxil edin:", "No degeri duzgun daxil edin:");
                        if (students.Exists(x => x.No == no))
                        {
                            userCRUD.ShowInfo();
                        }
                        else
                            Console.WriteLine("Bele id Yoxdur");
                        break;
                    case "5":
                        no = CheckInt("No degeri daxil edin:", "No degeri duzgun daxil edin:");
                        if (students.Exists(x => x.No == no))
                        {
                            Console.WriteLine("Ortalamaniz:");
                            Console.WriteLine(userCRUD.GetExamAvg());
                        }
                        else
                            Console.WriteLine("bele bir No yoxdur");
                        break;
                    case "6":
                        no = CheckInt("No degeri daxil edin:", "No degeri duzgun daxil edin:");
                        if (students.Exists(x => x.No == no))
                        {
                            Console.WriteLine("Silmek istediyiniz Exami daxil edin:");
                            string removeExamName = Console.ReadLine();
                            userCRUD.RemoveExam(removeExamName);
                            break;
                        }
                        else
                            Console.WriteLine("Bele bir No yoxdur");
                        break;
                    case "0":
                        check = false;
                        break;
                    default:
                        break;
                }
            } while (check);
        }
        static int CheckInt(string msg, string msg2)
        {
            Console.WriteLine(msg);
            string noStr = Console.ReadLine();
            bool isInt;
            int no;
            isInt = int.TryParse(noStr, out no);
            while (!isInt)
            {
                Console.WriteLine(msg2);
                noStr = Console.ReadLine();
                isInt = int.TryParse(noStr, out no);
            }
            return no;
        }
        static double CheckDouble(string msg, string msg2)
        {
            Console.WriteLine(msg);
            string DoubleStr = Console.ReadLine();
            bool isInt;
            double no;
            isInt = Double.TryParse(DoubleStr, out no);
            while (!isInt)
            {
                Console.WriteLine(msg2);
                DoubleStr = Console.ReadLine();
                isInt = double.TryParse(DoubleStr, out no);
            }
            return no;
        }

    }
}
