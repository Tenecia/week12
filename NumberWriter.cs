using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NumberWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            // create instance of StreamWriter
            StreamWriter writer = new StreamWriter("..\\..\\numbers.txt");
            // using statement to auto-close the program
            using(writer)
            {
                // loop from 1-20 and write number to a line
                for (int i = 1; i <= 20; i++) 
                {
                    writer.WriteLine(i);
                }


            }

        }
    }
}
