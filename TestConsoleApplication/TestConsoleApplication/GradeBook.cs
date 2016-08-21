using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApplication
{
    class GradeBook
    {

        public GradeBook()
        {
            grades = new List<float>();
        }

        private List<float> grades;

        public void AddGrades(float grade)
        {
            grades.Add(grade);
        }

        public void ReadGrades()
        {
            for (int i = 0; i < grades.Count; i++)
            {

                if (i != grades.Count -1)
                {
                    Console.Write($"{grades[i]}, ");
                }

                else
                {
                    Console.Write($"{grades[i]}.");
                }
            }
            Console.WriteLine();
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            foreach (var grade in grades)
            {
                stats.HighestGrade = Math.Max(stats.HighestGrade, grade);
                stats.LowestGrade = Math.Min(stats.LowestGrade, grade);
                sum += grade;
            }

            stats.AverageGrade = sum / grades.Count;

            return stats;
        }

        public void WriteResults(string description, float num)
        {
            Console.WriteLine($"{description}{num}");
        }
    }
}
