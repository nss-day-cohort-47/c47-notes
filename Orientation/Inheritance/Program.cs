using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor brenda = new Instructor()
            {
                Name = "Brenda",
                Weight = 5,
                Height = 5,
                Age = 22,
                SlackHandle = "@bjlong",
                Specialty = "UI/UX and JavaScript",
                Email = "brenda.long@nashvillesoftwareschool.com"
            };

            Student bob = new Student()
            {
                Name = "Bob",
                Age = 30,
                GPA = 3.8m,
                SlackHandle = "@bob",
                Height = 100,
                Weight = 22,
                Major = "C#",
            };

            Student sue = new Student()
            {
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

            List<Instructor> instructors = new List<Instructor>();
            instructors.Add(brenda);
            //instructors.Add(bob); // This is not allowed because bob is a Student

            Console.WriteLine("---------------------------");

            List<Person> people = new List<Person>();
            people.Add(brenda);
            people.Add(bob);
            people.Add(sue);

            foreach (Person p in people)
            {
                Console.WriteLine();
                p.Talk();
            }

            Console.WriteLine("---------------------------");

            List<ILearner> learners = new List<ILearner>();
            learners.Add(brenda);
            learners.Add(bob);
            learners.Add(sue);

            foreach (ILearner learner in learners)
            {
                learner.Learn("trumpet painting");
            }

            bob.Talk();
        }
    }
}