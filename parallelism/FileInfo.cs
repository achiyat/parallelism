using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace parallelism
{
    internal class FileInfo
    {
        public string txt { get; set; }
        public FileInfo(string f)
        {
            txt = f;
            //FileExists(txt);
        }



        public static void FileExists(string txt)
        {
            FileInfo fileInfo = new FileInfo(txt);

            if (!File.Exists(fileInfo.txt + ".txt"))
            {
                string fileNew = fileInfo.txt + ".txt";
                FileStream file = File.Create(fileNew);
            }
        }
    }

}
