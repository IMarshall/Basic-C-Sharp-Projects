using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name.");
            string date = DateTime.Today.ToShortDateString();
            string uname = Console.ReadLine();
            string msg = $"\nWelcome back {uname}. Today is {date}.";
            Console.WriteLine(msg);

            string path = @"C:\Users\imars\Documents\GitHub\Basic-C-Sharp-Projects\Scores\Scores\studentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);            

            double totalScore = 0;

            Console.WriteLine("\nStudent Score:\n");

            foreach(string line in lines)
            {
                Console.WriteLine("\n" + line);
                double score = Convert.ToDouble(line);
                totalScore += score;
            }
            double averageScore = totalScore / lines.Length;
            Console.WriteLine("\nTotal of {0} student scores: {1} \tAverage score: {2}.", lines.Length, totalScore, averageScore);
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
