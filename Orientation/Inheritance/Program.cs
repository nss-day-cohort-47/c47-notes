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
                GPA = 3.8m
            };

            brenda.Talk();

            bob.Talk();
            bob.SlackHandle = "@bob";
            bob.Talk();
        }
    }
}
