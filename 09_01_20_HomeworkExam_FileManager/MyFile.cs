using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_01_20_HomeworkExam_FileManager
{
    abstract class MyFile : IFileAttributes, IComparable<MyFile>
    {
        const bool HEBREW_FILES = true;
        readonly string _filePath;
        public string Filepath { get => _filePath; }
        public int FileSize { get; private set; }
        public bool FileIsReadOnly { get; private set; }
        public bool FileIsArchive { get; private set; }
        public bool FileIsVirused { get; private set; }

        public static List<string> filePaths = new List<string>();

        protected MyFile(string filePath, int fileSize, bool fileIsReadOnly, bool fileIsArchive)
        {
            _filePath = filePath;
            FileSize = fileSize;
            FileIsReadOnly = fileIsReadOnly;
            FileIsArchive = fileIsArchive;
            filePaths.Add(_filePath);

            if (VirusScanner.IsFileInfected(this)) throw new InfectedFileDetectedException(_filePath);

        }
        protected MyFile() { }

        public abstract object PrintFile();

        public int CompareTo(MyFile other)
        {
            return this.FileSize - other.FileSize;
        }
        public static bool operator ==(MyFile a, MyFile b)
        {
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null)) return true;

            return MyFile.StringComparing(a.Filepath, b.Filepath);
        }
        public static bool operator !=(MyFile a, MyFile b)
        {
            return !(a == b);
        }
        public override bool Equals(object obj)
        {
            return MyFile.StringComparing(this.Filepath, (obj as MyFile).Filepath);
        }
        public override int GetHashCode()
        {
            return this.Filepath.GetHashCode();
        }





        static public bool StringComparing(string a, string b)
        {
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null)) return true;

            if (a.Length != b.Length) return false;

            bool charsPairEquals = true;
            for (int i = 0; i < a.Length; i++)
            {
                if (!Equals(a[i], b[i])) { charsPairEquals = false; break; }
            }
            return charsPairEquals;
        }
    }
}
