// See https://aka.ms/new-console-template for more information
using SimpleGit;
using System;

Console.WriteLine("Hello, World!");
Console.WriteLine("I started the wrong projec, but i think this can still work");
Console.WriteLine("Lesson 1: How to loop over an array");

string[] provinces = { "Gauteng", "Limpopo", "Kwa-zulu natal", "Mpumalanga"};
foreach(string province in provinces)
{
    Console.WriteLine(province);
}
//end of the lesson

//Second lesson - method that prints lyics of a song 
static void Lyrics()
{
    Console.WriteLine("Areece Paradise");
    Console.WriteLine("bluh bluh bluh........");
}

Lyrics();

Student diplomaStudent = new Student("Alice", "20230101", 20, "Diploma in IT");
Student bcomStudent = new Student("Bob", "20230102", 21, "Bachelor of Commerce");
Student degreeStudent = new Student("Carol", "20230103", 22, "Bachelor of Science");
Student mastersStudent = new Student("Dave", "20230104", 25, "Master of Engineering");

diplomaStudent.DisplayInformation();