using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Utils
{
    public class FileHandler
    {
        public static void CreateFile(string fileName, string content)
        {
            File.WriteAllText($@"{AppDomain.CurrentDomain.BaseDirectory}\{fileName}", content);
        }
    }
}
