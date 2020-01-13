using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_01_20_HomeworkExam_FileManager
{
    class WordFile : MyFile, IWordCounter, ISpecificWordkCount
    {
        public string FileContent { get; set; }

        private Dictionary<string, int> _words = new Dictionary<string, int>();

        private string[] FileContentAsArray;
        public int NumberOfWords
        {
            get
            {
                return FileContentAsArray.Length;
            }
        }
        public int NumberofPages
        {
            get
            {
                int pagesNum = FileContentAsArray.Length / 10;
                if (FileContentAsArray.Length % 10 != 0) pagesNum++;
                return pagesNum;
            }
        }

        public string this[int ind]
        {
            get => FileContentAsArray[ind];
            set
            {
                FileContentAsArray[ind] = value;
                FileContent = String.Join(" ", FileContentAsArray);
            }
        }

        public WordFile(string fileContent, string filePath, int fileSize, bool fileIsArchive, bool fileIsReadOnly) : base(filePath, fileSize, fileIsArchive, fileIsReadOnly)
        {
            FileContent = fileContent;

            FileContentAsArray = fileContent.Split(' ');
            _words = HowMuchTimesEveryWordAppears(FileContentAsArray);
        }
        private Dictionary<string, int> HowMuchTimesEveryWordAppears(string[] words)
        {
            Dictionary<string, int> wordsAndTheirTimes = new Dictionary<string, int>();
            foreach(var s in words)
            {
                if (!wordsAndTheirTimes.ContainsKey(s)) wordsAndTheirTimes.Add(s, 1);
                else wordsAndTheirTimes[s]++;                
            }
            return wordsAndTheirTimes;
        }
        public int GetSpecificWordCount(string word)
        {
            return _words[word];
        }



        public override object PrintFile()
        {
            return String.Join("\n", FileContentAsArray);
        }
        public static bool operator ==(WordFile a, WordFile b)
        {
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null)) return true;

            return WordFile.StringComparing(a.FileContent, b.FileContent);
        }
        public static bool operator !=(WordFile a, WordFile b)
        {
            return !(a==b);
        }
            
        public override bool Equals(object obj)
        {
            //return this.FileContent == (obj as WordFile).FileContent;
            return StringComparing(this.FileContent, (obj as WordFile).FileContent);
        }
        public override int GetHashCode()
        {
            return this.FileContent.GetHashCode();
        }
        public static WordFile operator +(WordFile a, WordFile b)
        {
            string newFileContent = a.FileContent + b.FileContent;

            WordFile[] twoFiles = new WordFile[] {a, b};
            Array.Sort(twoFiles);
            string newFilePath = "mrg." + twoFiles.Last().Filepath;

            int newFileSize = a.FileSize + b.FileSize;
            //בשני הפרופרטיז הבולאניים האחרונים אין מנוס מלבחור באחד הקבצים, 
            //בתיאור כתוב שהם צריכים להיות זהים, אבל אם הם לא זהים בשני האובייקטים המושווים 
            //צריך לבחור באחת משתי האפשרויות הקיימות.
            bool newFileIsArchive = a.FileIsArchive;
            bool newFileIsReadOnly = a.FileIsReadOnly;

            
            return new WordFile(newFileContent, newFilePath, newFileSize, newFileIsArchive, newFileIsReadOnly);

        }

    }
}
