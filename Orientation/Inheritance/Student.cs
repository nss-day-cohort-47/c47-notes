using System;
using System.Collections.Generic;

namespace Inheritance
{
    public class Student : Person
    {
        public string Major { get; set; }
        public decimal GPA { get; set; }

        public List<string> Knowledge { get; } = new List<string>();

        public void Learn(string lesson)
        {
            Knowledge.Add(lesson);
        }

        public override void Talk()
        {
            base.Talk();
            if (Knowledge.Count > 0)
            {
                Console.WriteLine("I know theses things:");
                foreach (string lesson in Knowledge)
                {
                    Console.WriteLine(lesson);
                }
            }
        }
    }
}