using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Student.CSharp
{
    internal class Student
    { 
        public string StudentId { get; }
        public string FullName { get; set; }

        public List<int> grades = new List<int>();

        public Student(string id, string fullName) 
        {
            this.StudentId = id;
            this.FullName = fullName;
        }

        public void AddGrade(int grade) { 

            if(grade < 5 || grade > 10)
            {
                Console.WriteLine("Grade must be between 5 and 10.");
                return;
            }

            grades.Add(grade);
        }

        public double GetAverage()
        {
            if (grades.Count == 0)
            {
                return 0;
            }
            
            int sum = 0;

            foreach (int grade in grades)
            {
                sum += grade;
            }

            return (double)sum / grades.Count;
        }

        public bool HasPassed()
        {
            if (grades.Count == 0)
            {
                return false;
            }

            foreach (int grade in grades)
            {
                if (grade < 6)
                {
                    return false;
                }
            }

            return true;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Student ID: {StudentId}");
            Console.WriteLine($"Full name: {FullName}");

            string gradeText = grades.Count == 0
                ? "No grades"
                : string.Join(", ", grades);

            Console.WriteLine($"Grades: {gradeText}");
            Console.WriteLine($"Average: {GetAverage():F2}");
            Console.WriteLine($"Has passed: {HasPassed()}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student firstStudent = new Student(
                "101", "Daniel Karamanov");

            Student secondStudent = new Student(
                "102", "Test Student");

            // Student with no grades
            firstStudent.PrintInfo();

            Console.WriteLine();

            firstStudent.AddGrade(8);
            firstStudent.AddGrade(9);
            firstStudent.AddGrade(10);

            secondStudent.AddGrade(6);
            secondStudent.AddGrade(5);
            secondStudent.AddGrade(7);

            // Invalid grades will not be added
            firstStudent.AddGrade(4);
            secondStudent.AddGrade(11);

            Console.WriteLine();
            firstStudent.PrintInfo();

            Console.WriteLine();
            secondStudent.PrintInfo();
        }
    }
}
