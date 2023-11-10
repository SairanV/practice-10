using practice_10.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_10.Class
{
    public class Student : IStudent
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public int[] Grades { get; set; }

        public string GetName()
        {
            return Name;
        }

        public string GetFullName()
        {
            return FullName;
        }

        public double GetAvgGrade()
        {
            if (Grades.Length == 0)
                return 0;

            int sum = 0;
            foreach (var grade in Grades)
            {
                sum += grade;
            }

            return (double)sum / Grades.Length;
        }
    }
}
