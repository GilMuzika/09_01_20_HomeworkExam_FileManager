using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_01_20_HomeworkExam_FileManager
{
    class ComboItem<T>
    {
        public T Item { get; set; } = default(T);

        public ComboItem(T item)
        {
            Item = item;
        }

        public override string ToString()
        {
            /*string str = string.Empty;
            for(int i = 0; i < Item.GetType().GetProperties().Length; i++)
            {
                str += $"{Item.GetType().GetProperties()[i].GetValue(this.Item)} ";
            }
            return str;*/

            return Item.GetType().GetProperties()[1].GetValue(this.Item).ToString();
            //return Item.ToString();
        }
    }
}
