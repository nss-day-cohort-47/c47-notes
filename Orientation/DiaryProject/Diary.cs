using System;
using System.Collections.Generic;

namespace DiaryProject
{
    public class Diary
    {
        // constructor
        public Diary(string owner)
        {
            Owner = owner;
            CreationDate = DateTime.Now;
            _entries = new List<string>();
        }

        // property
        public string Owner { get; set; }
        public DateTime CreationDate { get; set; }

        // field
        private List<string> _entries;

        // method
        public void AddEntry(string entry)
        {
            _entries.Add(entry);
        }

        public void PrintEntries()
        {
            foreach (string entry in _entries)
            {
                Console.WriteLine(entry);
            }
        }
    }
}