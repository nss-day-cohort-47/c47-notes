using System;

namespace Inheritance
{
    public class Instructor : Person
    {
        public string Specialty { get; set; }
        public string Email { get; set; }

        public void Teach(Student student)
        {
            student.Learn(Specialty);
        }

        public override void Talk()
        {
            Console.WriteLine($"I'm an instructor, my name is {Name}. My specialty is {Specialty}.");
        }
    }
}