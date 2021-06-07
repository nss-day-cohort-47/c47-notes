using System;

namespace Inheritance
{
    public class Student : Person
    {
        public string Major { get; set; }
        public decimal GPA { get; set; }

        public override void Talk()
        {
            base.Talk();
            Console.WriteLine($"My GPA is {GPA}.");
        }
    }
}