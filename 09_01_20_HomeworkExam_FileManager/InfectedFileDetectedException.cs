using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_01_20_HomeworkExam_FileManager
{
    class InfectedFileDetectedException: Exception
    {
        public InfectedFileDetectedException(string filepath) : base($"The file is infected. Path to the file: {filepath}")
        {

        }
    }
}
