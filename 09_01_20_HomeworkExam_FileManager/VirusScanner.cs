using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_01_20_HomeworkExam_FileManager
{
    static class VirusScanner
    {
        public static int MalwareSize { get; }
        static VirusScanner()
        {
            MalwareSize = Convert.ToInt32(ConfigurationManager.AppSettings["MalwareSize"]);
        }

        public static bool IsFileInfected(MyFile file)
        {
            if (file.FileSize.Equals(MalwareSize)) return true;
            else return false;
        }
    }
}
