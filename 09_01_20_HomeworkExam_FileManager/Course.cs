using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_01_20_HomeworkExam_FileManager
{
    class Course: Poco
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public int HOURS { get; set; }
        public decimal AVG_GRADE { get; set; }
        public int NUM_OF_STUDENTS { get; set; }
        public int HIGHEST_GRADE { get; set; }
        public string EXTERNAL_ID { get; set; }

        public Course(string nAME, int hOURS, decimal aVG_GRADE, int nUM_OF_STUDENTS, int hIGHEST_GRADE)
        {
            NAME = nAME;
            HOURS = hOURS;
            AVG_GRADE = aVG_GRADE;
            NUM_OF_STUDENTS = nUM_OF_STUDENTS;
            HIGHEST_GRADE = hIGHEST_GRADE;
            EXTERNAL_ID = Statics.GetUniqueKeyOriginal_BIASED(4000);
        }
        public Course() { }
    }
}
