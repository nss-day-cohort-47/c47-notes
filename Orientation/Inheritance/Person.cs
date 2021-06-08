using System;

namespace Inheritance
{
    public class Person
    {
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string SlackHandle { get; set; }

        public virtual void Talk()
        {
            Console.WriteLine($"Hello, my name is {Name}! My slackhandle is {SlackHandle}");
        }
    }
}
