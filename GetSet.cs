using System;

namespace ConsoleApp
{
    class Person
    {
        public string Name { get; set; }
    }

    class Student : Person
    {
        public string studentNumber { get; set; }
        public string email { get; set; }
        public int phone { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Student student = new Student();

            student.studentNumber = "Ahlam";
            student.email = "ahlam@gmail.com";
            student.phone = 123456789;

            Console.WriteLine($"Student Number: {student.studentNumber}, Email: {student.email}, Phone: {student.phone}");

        }
    }
}