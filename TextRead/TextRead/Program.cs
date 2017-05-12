using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRead
{
    class Program
    {
        static void Main(string[] args)
        {
            FileOperation op = new FileOperation();
            string textline = op.ReadFile("TextFile1.txt");
            
            Speech speak = new Speech();
            speak.ReadText(textline);
        }
    }
}
