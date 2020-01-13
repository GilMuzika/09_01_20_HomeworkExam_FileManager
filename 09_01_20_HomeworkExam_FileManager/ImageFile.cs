using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_01_20_HomeworkExam_FileManager
{
    class ImageFile<T> : MyFile
    {
        private Random _rnd = new Random();
        public T[,] FileColors { get; set; }
        private Color[,] realFileColor;
        public ImageFile(T[,] fileColors, string filePath, int fileSize, bool fileIsArchive, bool fileIsReadOnly) : base(filePath, fileSize, fileIsArchive, fileIsReadOnly)
        {
            FileColors = fileColors;
            realFileColor = new Color[FileColors.GetLength(0), FileColors.GetLength(1)];
            for(int i = 0; i < FileColors.GetLength(0); i++)
            {
                for(int j = 0; j < FileColors.GetLength(1); j++)
                {
                    realFileColor[i, j] = Color.FromArgb(_rnd.Next(255), _rnd.Next(255), _rnd.Next(255), _rnd.Next(255));
                }
            }

        }
        public override object PrintFile()
        {
            Bitmap picture = new Bitmap(FileColors.GetLength(0), FileColors.GetLength(1));
            for(int i = 0; i < FileColors.GetLength(0); i++)
            {
                for(int j = 0; j < FileColors.GetLength(1); j++)
                {
                    picture.SetPixel(i, j, realFileColor[i, j]);
                }
            }
            using (Graphics graphicsObj = Graphics.FromImage(picture))
            {
                graphicsObj.DrawImage(picture, 0, 0);
            }
            return picture;
        }
    }
}
