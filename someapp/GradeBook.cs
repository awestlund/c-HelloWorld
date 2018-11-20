using System;
using System.Collections.Generic;

namespace someapp
{
    class GradeBook
    {
        List<float> grades;
        static float maxGrade = 100;
        static float minGrade = 0;

        public GradeBook()
        {
            // constructor
            this.grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
        public float CalcAverage(float sum)
        {
            float avg = sum /grades.Count;
            
            return avg;
        }
        public float CalcSum()
        {
            float sum = 0;
            foreach(float grade in grades){
                sum += grade;
            }
            return sum;
        }
        public Statistics computeStats(){
            Statistics stats =  new Statistics();

            float sum = CalcSum();

            stats.AvgGrade = CalcAverage(sum);

            // get the highest and lowest values in the grade book
            foreach(float grade in grades){
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
            }

            return stats;
        }

    }
}