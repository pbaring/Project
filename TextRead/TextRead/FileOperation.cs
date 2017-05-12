using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextRead
{
    class FileOperation
    {
        public string ReadFile(string filename)
        {
           string text = "";
           using (StreamReader reader = new StreamReader(filename))
           {
               text += reader.ReadLine();
           }

           return text;
        }


    }
}
