using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_12._14._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int inpreqem;
            K300_K100 kqrup = new K300_K100();
            do
            {

                Console.WriteLine("Yalniz asagidaki reqemlerden birini daxil ede bilersiz");
                Console.WriteLine("1.Add Students");
                Console.WriteLine("2.Select Student and Add Exam");
                Console.WriteLine("3.Exam List");
                Console.WriteLine("4.Exit");
                Console.Write(">>>>>");
                
               string inputUser = Console.ReadLine();

                if (int.TryParse(inputUser,out inpreqem))
                {
                    switch (inpreqem)
                    {
                        case 1:
                            kqrup.AddStudent();
                            break;
                        case 2:
                            Console.WriteLine("Imtahan daxil edildi");
                            break;
                        case 3:
                            kqrup.ShowStudent(); 
                            break;
                        case 4:
                            break;
                        default:
                            Console.WriteLine("Zehmet olmasa 1-4 arasinda reqem daxil edin");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Zehmet olmasa reqem daxil edin");
                }

            } while (inpreqem!=4);
        }


    }
}
