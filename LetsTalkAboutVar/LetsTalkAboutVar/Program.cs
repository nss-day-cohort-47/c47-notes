using System;
using System.Collections.Generic;

namespace LetsTalkAboutVar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Both "myHouse" and "myVarHouse" are equivalent 
            House myHouse = new House()
            {
                Address = "123 Main St",
                FloorCount = 1,
                SquareFeet = 1_200,
                Color = "blue",
            };
            var myVarHouse = new House()
            {
                Address = "123 Main St",
                FloorCount = 1,
                SquareFeet = 1_200,
                Color = "blue",
            };


            var chester = new Ghost()
            {
                Age = 200,
                Name = "Chester the ghost"
            };

            var spookyJane = new Ghost()
            {
                Age = 144,
                Name = "Sppoky Jane",
            };

            // We can use "var" when declaring a list
            var ghosts = new List<Ghost>() { chester, spookyJane };

            // we can use "var" in a "foreach"
            foreach (var ghost in ghosts)
            {
                myHouse.AddGhost(ghost);
            }

            // we can use "var" when we are getting a value from a property or method
            var isHaunted = myHouse.IsHaunted;

            if (isHaunted)
            {
                Console.WriteLine("I feel creepy...");
            }
        }
    }

    public class House
    {
        // we cannot use "var" for private fields
        private List<Ghost> _ghosts = new List<Ghost>();

        // we cannot use "var" for properties
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

        // We cannot use var for parameters
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
