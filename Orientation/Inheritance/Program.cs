using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor brenda = new Instructor() {
                Name = "Brenda",
                Weight = 5,
                Height = 5,
                Age = 22,
                SlackHandle = "@bjlong",
                Specialty = "UI/UX and JavaScript",
                Email = "brenda.long@nashvillesoftwareschool.com"
            };

            Student bob = new Student() {
                Name = "Bob",
                Age = 30,
                GPA = 3.8m,
                SlackHandle = "@bob",
                Height = 100,
                Weight = 22,
                Major = "C#",
            };

            Student sue = new Student() {
                Name = "Sue",
                Age = 34,
                GPA = 3.8m,
                SlackHandle = "@sue",
                Height = 200,
                Weight = 40,
                Major = "full stack"
            };

            brenda.Talk();
            bob.Talk();
            sue.Talk();

            sue.Learn("SQL");
            sue.Learn("CSS");
            bob.Learn("Lists");

            Console.WriteLine("---------------------------");
            bob.Talk();

            Console.WriteLine("---------------------------");
            sue.Talk();

            Console.WriteLine("---------------------------");

            brenda.Teach(bob);

            Console.WriteLine("---------------------------");
            bob.Talk();

            Console.WriteLine("---------------------------");
            sue.Talk();
        }
    }
}
