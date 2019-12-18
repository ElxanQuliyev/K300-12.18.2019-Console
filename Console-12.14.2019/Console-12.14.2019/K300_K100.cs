using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_12._14._2019
{
    class K300_K100
    {
        public List<Students> studenList { get; set; }
        public List<Exams> examList { get; set; }
        Students selecetedStudent;
        public K300_K100()
        {
            studenList = new List<Students>();
            examList = new List<Exams>();
            Exams exm1 = new Exams("Html",DateTime.Parse("2019-06-06"));
            Exams exm2 = new Exams("Css", DateTime.Parse("2019-02-01"));
            Exams exm3 = new Exams("C#", DateTime.Parse("2019-06-16"));
            examList.Add(exm1);
            examList.Add(exm2);
            examList.Add(exm3);
        }
        public void AddStudent()
        {
            Console.WriteLine("Telebe adini daxil edin:");
            string userInput = Console.ReadLine();
            if (userInput.Length != 0)
            {
               Students st = new Students(userInput);
                studenList.Add(st);
                foreach (var item in studenList)
                {
                    Console.WriteLine($"id:{item.Id}, Telebe Adi {item.Fullname} uğurla əlavə edildi");
                }
            }
            else
            {

            }

        }
        public void ShowStudent()
        {
            Console.WriteLine("\n******************");
            foreach (Students item in studenList)
            {
                Console.WriteLine($"id:{item.Id},Telebe adi:{item.Fullname}");
            }
            Console.WriteLine("\n******************");
            Start:
            Console.Write("Zehmet olmasa Telebe Id'ni daxil Edin:");
            string userInp = Console.ReadLine();
            int inputId;
            bool correctId = false;
            if(int.TryParse(userInp,out inputId))
            {
                foreach (var stu in studenList)
                {
                    if (stu.Id == inputId)
                    {
                        selecetedStudent = stu;
                        correctId = true;
                        Console.WriteLine("Duzgundur");
                        break;

                    }
                }
                if (correctId)
                {
                    ExamShow();
                    ExamStart:
                    Console.Write("Imtahan Id'ni daxil et!");
                    string examInput = Console.ReadLine();
                    int exmId;
                    if(int.TryParse(examInput,out exmId))
                    {
                        foreach(Exams exm in examList)
                        {
                            if (exm.examId == exmId)
                            {
                                selecetedStudent.examStuList.Add(exm);
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("imtahan id'ni duzgun daxil et!");
                        goto ExamStart;
                    }
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Telebe Id-ni düzgün daxil edin!");
                    goto Start;
                }
                
            }
            else
            {
                Console.WriteLine("Zehmet olmasa id reqem daxil edin!");
                goto Start;
            }

        }
        public void ExamShow()
        {
            foreach (Exams item in examList)
            {
                Console.WriteLine($" №{item.examId} Imtahan adi:{item.ExamName}");
            }
        }
    }
}
