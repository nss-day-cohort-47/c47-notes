using System;

namespace DiaryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary myDiary = new Diary("Andy");
            Diary another = new Diary("Traye");

            Console.WriteLine("Diary Owner");
            Console.WriteLine(myDiary.Owner);
            myDiary.Owner = "Bob";
            Console.WriteLine(myDiary.Owner);

            Console.WriteLine();

            Console.WriteLine("Diary Object");
            Console.WriteLine(myDiary);

            Console.WriteLine();

            myDiary.AddEntry("Talked about classes today.");
            myDiary.AddEntry("Really confused the students");
            myDiary.PrintEntries();

       }
    }
}