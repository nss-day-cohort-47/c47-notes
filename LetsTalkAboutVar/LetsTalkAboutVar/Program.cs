using System;
using System.Collections.Generic;

namespace LetsTalkAboutVar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boo!");
        }
    }

    public class House
    {
        private List<Ghost> _ghosts = new List<Ghost>();
        public string Address { get; set; }
        public int FloorCount { get; set; }
        public double SquareFeet { get; set; }
        public string Color { get; set; }

        public bool IsHaunted
        {
            get
            {
                return _ghosts.Count > 0;
            }
        }

        public void AddGhost(Ghost ghost)
        {
            _ghosts.Add(ghost);  
        }
    }

    public class Ghost
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
}
