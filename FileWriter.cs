using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            // create instance of StreamWriter
            StreamWriter writer = new StreamWriter("..\\..\\Answers.txt");
            //using will auto close the stream 
            using(writer)
            {
                // write a line
                writer.WriteLine("Hello World");
            }
        }
    }
}
