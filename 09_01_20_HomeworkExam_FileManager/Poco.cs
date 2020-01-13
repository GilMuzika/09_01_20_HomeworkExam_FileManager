using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_01_20_HomeworkExam_FileManager
{
    class Poco
    {
        protected Random _rnd = new Random();
        public override string ToString()
        {
            string str = string.Empty;
            for (int i = 1; i < this.GetType().GetProperties().Length-1; i++)
            {
                str += $"{this.GetType().GetProperties()[i].Name}: {this.GetType().GetProperties()[i].GetValue(this)}\n";
            }
            return str;
        }
    }
}
