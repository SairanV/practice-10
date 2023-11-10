using practice_10.Class;
using practice_10.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IStudent student = new Student
            {
                Name = "Айдонт",
                FullName = "Айдонт Непон",
                Grades = new int[] { 80, 101, 75, 88, 100 } // | C# | Музыка | Физкультура | Java | Просмотр YouTube |
            };

            Console.WriteLine($"Имя студента: {student.GetName()}");
            Console.WriteLine($"Полное имя студента: {student.GetFullName()}");
            Console.WriteLine($"Средний балл студента: {student.GetAvgGrade()}");
        }
    }
}
