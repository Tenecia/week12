using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileReader
{
    class Program
    {
        static void Main(string[] args) // this file is non-static 
        {
            using (reader)
            { 
            // create an instance of stream reader
            StreamReader reader = new StreamReader("..\\..\\Sample.txt");
            int lineNumber = 0; 
            // read first line from text file 
            string line = reader.ReadLine();
            // read other lines from text file 
            while (line != null) 
            {
                lineNumber++;
                Console.WriteLine("Line{0}:{1}", lineNumber, line);
                line = reader.ReadLine();
            }
            // close the program 
           // reader.Close(); *** no longer need this because using(reader) will close your stream for you. 
            }
        }
    }
}
