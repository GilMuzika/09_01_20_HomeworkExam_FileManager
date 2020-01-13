using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_01_20_HomeworkExam_FileManager
{
    interface IWordCounter
    {
        int NumberOfWords { get; }
        int NumberofPages { get; }
        string this[int ind] { get; set; }
    }
}
