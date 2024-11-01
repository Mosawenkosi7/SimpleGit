using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGit
{
    internal class Student
    {
        public string Name { get; set; }
        public string StudentNumber { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        public void DisplayInformation()
        {
            Console.WriteLine("Student details are as follows:");
            Console.WriteLine(@$"
Name: {Name}
Student Number: {StudentNumber}
Age: {Age}
Course: {Course}");
        }

        public Student(string name, string studentNumber, int age, string course)
        {
            Name = name;
            StudentNumber = studentNumber;
            Age = age;
            Course = course;
        }
    }
}
