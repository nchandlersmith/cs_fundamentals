using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(81.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine("The highest grade is " + stats.HighestGrade);
            Console.WriteLine("The average grade is " + stats.AverageGrade);
            Console.WriteLine("The lowest grade is " + stats.LowestGrade);
        }
    }
}
