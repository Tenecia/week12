using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestPaths
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "..\\..\\Test.txt";
            StreamReader reader = new StreamReader(fileName);  // step one: open stream 

            // step 2: Do something
            string myLine = reader.ReadLine();

            Console.WriteLine(myLine);

            // step 3: CLose it 
            reader.Close();
        }
    }
}
