using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double avgGrade)
        {
            if (Students.Count < 5)
            {
                throw new System.InvalidOperationException("Students number less than 5");
            }
            if (avgGrade >= 80)
                return 'A';
            else if (avgGrade < 80 && avgGrade >= 60)
                return 'B';
            else if (avgGrade >= 40 && avgGrade < 60)
                return 'C';
            else if (avgGrade >= 20 && avgGrade < 40)
                return 'D';
            else
                return 'F';
        }

        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else
            {
                base.CalculateStatistics();
            }
        }
        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else
            {
                base.CalculateStudentStatistics(name);
            }
        }
    }
}