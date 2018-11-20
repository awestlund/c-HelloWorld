using System;

namespace someapp
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook myBook = new GradeBook();
            myBook.AddGrade(97);
            // add an f at the end of a double to make it a float
            myBook.AddGrade(97.8f);

            Statistics stats = myBook.computeStats();

            System.Console.WriteLine("Average Grade: " + stats.AvgGrade);
            System.Console.WriteLine("Highest Grade: " + stats.HighestGrade);
            System.Console.WriteLine("Lowest Grade: " + stats.LowestGrade);

        }
    }
}
