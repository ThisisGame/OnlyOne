using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OnlyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("./1.txt"))
            {
                string tmpContent = sr.ReadToEnd();

                string tmpContentDst = "";
                for (int i = 0; i < tmpContent.Length; i++)
                {
                    if (tmpContentDst.Contains(tmpContent[i]) == false)
                    {
                        tmpContentDst += tmpContent[i];
                    }
                }

                using (StreamWriter sw = new StreamWriter("./OnlyOne.txt"))
                {
                    sw.Write(tmpContentDst);
                }
            }
        }
    }
}
