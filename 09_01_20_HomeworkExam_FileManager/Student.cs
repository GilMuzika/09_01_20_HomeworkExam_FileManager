using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_01_20_HomeworkExam_FileManager
{
    class Student: Poco
    {
        public int ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string ADDRESS { get; set; }
        public int AGE { get; set; }
        public string EXTERNAL_ID { get; set; }

        public Student(string fIRST_NAME, string lAST_NAME, string aDDRESS, int aGE)
        {
            FIRST_NAME = fIRST_NAME;
            LAST_NAME = lAST_NAME;
            ADDRESS = aDDRESS;
            AGE = aGE;
            EXTERNAL_ID = Statics.GetUniqueKeyOriginal_BIASED(4000);
        }
        public Student() { }
    }
}
