using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_01_20_HomeworkExam_FileManager
{
    class MyFileCompareByFilePathComparer : IComparer<MyFile>
    {
        public int Compare(MyFile x, MyFile y)
        {
            if (ReferenceEquals(x.Filepath, y.Filepath)) return 0;
            else return compareCharsNumericReprsentation(x, y);

        }

        private int compareCharsNumericReprsentation(MyFile x, MyFile y)
        {
            for (int i = 0; i < x.Filepath.Length; i++)
            {
                for (int j = 0; j < y.Filepath.Length; j++)
                {
                    if ((int)x.Filepath[i] != (int)y.Filepath[j])
                    {
                        if ((int)x.Filepath[i] > (int)y.Filepath[j]) return 1;
                        if ((int)x.Filepath[i] < (int)y.Filepath[j]) return -1;
                    }

                }
            }

            return 0;



        }
    }
}
