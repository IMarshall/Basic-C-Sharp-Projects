using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoggingToTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //ASK FOR USER INPUT
            Console.WriteLine("Please enter a number.");
            //ASSIGN USER INPUT TO STRING
            string userInput = Console.ReadLine();
            //ASSIGN FILEPATH FOR LOG FILE TO STRING
            string filePath = @"C:\Users\imars\OneDrive\Documents\GitHub\Basic-C-Sharp-Projects\LoggingToTextFile\log.txt";
            //LOG USER INPUT IN FILE
            File.WriteAllText(filePath, userInput);
            //READ TEXT FROM FILE AND PRINT TO CONSOLE
            Console.WriteLine(File.ReadAllText(filePath));

            Console.Read();
        }
    }
}
