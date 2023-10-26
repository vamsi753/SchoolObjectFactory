using System;
using System.Collections.Generic;

namespace SchoolObjectFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create student, teacher, and subject objects using the Factory Method
            var schoolFactory = SchoolObjectFactorySingleton.Instance;

            var student1 = schoolFactory.CreateStudent("John Doe", "Class A");
            var student2 = schoolFactory.CreateStudent("Jane Smith", "Class B");

            var teacher1 = schoolFactory.CreateTeacher("Mr. Johnson", "Class A");
            var teacher2 = schoolFactory.CreateTeacher("Mrs. Brown", "Class B");

            var subject1 = schoolFactory.CreateSubject("Math", "MATH101", teacher1);
            var subject2 = schoolFactory.CreateSubject("Science", "SCI101", teacher2);

            // Display the created objects
            Console.WriteLine("Students:");
            Console.WriteLine($"{student1.Name}, {student1.ClassSection}");
            Console.WriteLine($"{student2.Name}, {student2.ClassSection}");

            Console.WriteLine("\nTeachers:");
            Console.WriteLine($"{teacher1.Name}, {teacher1.ClassSection}");
            Console.WriteLine($"{teacher2.Name}, {teacher2.ClassSection}");

            Console.WriteLine("\nSubjects:");
            Console.WriteLine($"{subject1.Name}, {subject1.SubjectCode}, Teacher: {subject1.Teacher.Name}");
            Console.WriteLine($"{subject2.Name}, {subject2.SubjectCode}, Teacher: {subject2.Teacher.Name}");
        }
    }

    class Student
    {
        public string Name { get; set; }
        public string ClassSection { get; set; }
    }

    class Teacher
    {
        public string Name { get; set; }
        public string ClassSection { get; set; }
    }

    class Subject
    {
        public string Name { get; set; }
        public string SubjectCode { get; set; }
        public Teacher Teacher { get; set; }
    }

    class SchoolObjectFactory
    {
        public Student CreateStudent(string name, string classSection)
        {
            return new Student { Name = name, ClassSection = classSection };
        }

        public Teacher CreateTeacher(string name, string classSection)
        {
            return new Teacher { Name = name, ClassSection = classSection };
        }

        public Subject CreateSubject(string name, string subjectCode, Teacher teacher)
        {
            return new Subject { Name = name, SubjectCode = subjectCode, Teacher = teacher };
        }
    }

    class SchoolObjectFactorySingleton
    {
        private static SchoolObjectFactory _instance;

        private SchoolObjectFactorySingleton() { }

        public static SchoolObjectFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SchoolObjectFactory();
                }
                return _instance;
            }
        }
    }
}
