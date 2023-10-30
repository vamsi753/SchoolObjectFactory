using System;
using System.Collections.Generic;

namespace SchoolObjectFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();
            List<Teacher> teachers = new List<Teacher>();
            List<Subject> subjects = new List<Subject>();

            students.Add(new Student { Name = "John", SubjectCode = "Math101", Teacher = "Mr. Smith" });
            students.Add(new Student { Name = "Alice", SubjectCode = "Bio101", Teacher = "Mrs. Johnson" });

            teachers.Add(new Teacher { Name = "Mr. Smith" });
            teachers.Add(new Teacher { Name = "Mrs. Johnson" });

            subjects.Add(new Subject { SubjectCode = "Math101" });
            subjects.Add(new Subject { SubjectCode = "Bio101" });

  
            Console.WriteLine("Students in Math101 class:");
            foreach (var student in students)
            {
                if (student.SubjectCode == "Math101")
                {
                    Console.WriteLine(student.Name);
                }
            }

  
            Console.WriteLine("Subjects taught by Mr. Smith:");
            foreach (var subject in subjects)
            {
                foreach (var student in students)
                {
                    if (student.SubjectCode == subject.SubjectCode && student.Teacher == "Mr. Smith")
                    {
                        Console.WriteLine(subject.SubjectCode);
                    }
                }
            }
        }
    }
}
