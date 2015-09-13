using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EmployerQuestionAnswers
{
    class Program
    {
        static void Main(string[] args)
        {
            //string answer;
            StreamReader reader = new StreamReader("..\\..\\Questions.txt");
            StreamWriter writer = new StreamWriter("..\\..\\Answers.txt"); // user input answers will go here when using the program 
            StringBuilder builder = new StringBuilder();
            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;   // goes to next line 
                     
                    //writer.WriteLine("ANSWER ANSWER ANSWER ANSWER");
                    Console.WriteLine(line); // writes the line
                    builder.Append(Console.ReadLine()); // makes it so you can add your answer to the question 
                    builder.AppendLine();// ADDS a space 
                    line = reader.ReadLine();  //                   

                }

                    }
                    using (writer) 
                    {
                        writer.WriteLine(builder);
                    }

                }
            }
        }

    


