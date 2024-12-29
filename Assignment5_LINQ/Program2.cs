using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_LINQ
{

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Grade { get; set; }
    }
    class Program2
    {

        static void Main(string[] args)
        {

            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Raj", Grade = "A" },
                new Student { Id = 2, Name = "Suraj", Grade = "B" },
                new Student { Id = 3, Name = "Mitali", Grade = "A" },
                new Student { Id = 4, Name = "Anjali", Grade = "C" },
                new Student { Id = 5, Name = "Andrea", Grade = "B" },
                new Student { Id = 5, Name = "Anushi", Grade = "A" }
            };

            Console.WriteLine("Enter the grade to search for:");
            string inputGrade = Console.ReadLine();


            var filteredStudents = students
                .Where(student => student.Grade.Equals(inputGrade, StringComparison.OrdinalIgnoreCase))
                .ToList();


            if (filteredStudents.Count == 0)
            {
                Console.WriteLine($"No students found with grade {inputGrade}.");
            }
            else
            {
                Console.WriteLine($"Students with grade {inputGrade}:");
                foreach (var student in filteredStudents)
                {
                    Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Grade: {student.Grade}");
                }
            }

            Console.ReadLine();
        }
    }
}
