using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_12._14._2019
{
    class Exams
    {
        public int examId { get;private set; }
        private static int exmId=1;
        public string ExamName { get; set; }
        public DateTime ExamDate { get; set; }
        public Exams(string ExamName,DateTime Date)
        {
            this.ExamName = ExamName;
            ExamDate = Date;
            examId = exmId;
            exmId++;
        }
     }
}
