using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_12._14._2019
{
    class Students
    {
        public int Id { get; private set; }
        public string Fullname { get; set; }

        private static int stuId=1;
        public List<Exams> examStuList { get; set; }
        public Students(string nm)
        {
            examStuList = new List<Exams>();
            Fullname = nm;
            Id = stuId;
            stuId++;
        }
    }
}   
