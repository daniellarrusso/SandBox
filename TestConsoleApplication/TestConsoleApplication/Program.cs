using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();

            book.AddGrades(98.5f);
            book.AddGrades(52.5f);
            book.AddGrades(87);

            book.ReadGrades();

            GradeStatistics stats = book.ComputeStatistics();
            book.WriteResults("Average:", stats.AverageGrade);
            book.WriteResults("Lowest:", stats.LowestGrade);
            book.WriteResults("Highest:", stats.HighestGrade);

            Console.ReadLine();
        }
    }
}
