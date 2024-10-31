// See https://aka.ms/new-console-template for more information
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