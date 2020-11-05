using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook:BaseGradeBook
    {
        public RankedGradeBook(string name, bool isweighted) :base(name, isweighted)
        {
            Name = name;
            IsWeighted = isweighted;
            Type = Enums.GradeBookType.Ranked;

        }

        public override char GetLetterGrade(double averageGrade)
        {
            double N = Students.Count / 5;
            List<double> listStudentsGrade = new List<double>();

            if (Students.Count < 5)
            {
                throw new Exception();
            }
            else
            {
                double studentsQuantity = (0.2 * Students.Count);
                int indexer = 0;
                for(int i = 0; i < Students.Count; i++)
                {
                    if(Students[i].AverageGrade > averageGrade)
                    {
                        indexer++;
                    }
                }
                double checkGrade = indexer/ studentsQuantity;

                    if (checkGrade >= 0 && checkGrade < 1)
                    return 'A';
                else if (checkGrade >= 1 && checkGrade < 2)
                    return 'B';
                else if (checkGrade >= 2 && checkGrade < 3)
                    return 'C';
                else if (checkGrade >= 3 && checkGrade < 4)
                    return 'D';
                else if (checkGrade >= 4 && checkGrade < 5)
                    return 'F';
                else
                    return 'F';
                //List<Student> studenstListWithGrade = new List<Student>();
                //for (int i = 0; i < Students.Count; i++)
                //{
                //    if (Students[i].AverageGrade > averageGrade)
                //    {
                //        studenstListWithGrade.Add(Students[i]);
                //    }

                //    //for(int j = 0; j < Students[i].Grades.Count; j++)
                //    //{
                //}

                //if (averageGrade <= 100 && averageGrade >= 80)
                //    return 'A';
                //else if (averageGrade < 80 && averageGrade >= 60)
                //    return 'B';
                //else if (averageGrade < 60 && averageGrade >= 40)
                //    return 'C';
                //else if (averageGrade < 40 && averageGrade >= 20)
                //    return 'D';
                //else if (averageGrade < 20 && averageGrade >= 0)
                //    return 'F';
                //else
                //    return 'F';
            }
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

