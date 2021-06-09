using System;
using System.Collections.Generic;

List<string> groceryList = new List<string>()
{
    "foo",
    "bar",
    "baz"
};

Console.Write("First Name> ");
string firstName = Console.ReadLine();

Console.Write("Last Name> ");
string lastName = Console.ReadLine();

Console.WriteLine($"{lastName} {firstName}");

// ===========================================

string reverse = "";
string fullName = firstName + " " + lastName;

for (int i = fullName.Length - 1; i >= 0; i--)
{
    reverse = reverse + fullName[i];
    /*
    "" + "x"
    "x" + "r"
    "xr" + "a"
    "xra" + "M"
    ...
    */
}

Console.WriteLine(reverse);

// ===========================================

for (int i = fullName.Length - 1; i >= 0; i--)
{
    Console.Write(fullName[i]);
}

/*
Console.Write("Who would you like to say hello to? ");

string name = Console.ReadLine();

if (string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("Blah - ");
    Console.WriteLine("Fine, don't say 'hello'!");
}
else
{
    Console.WriteLine($"Hello, {name}!");
}
*/
// this is some text

Person taco = new Person() { Name = "Phil" };
taco = new Person() { Name = "Mary" };


Automobile a = new Automobile();
a.Break();
//a.Honk();
//a.SqueezeBreakPads();

Car c = new Car();

public class Person
{
    public string Name { get; set; }
}

public class Automobile {

    public string Break() {
        SqueezeBreakPads();
        return "skuuuuuur";
    }



    protected string SqueezeBreakPads() {
        return "";
    }

    private void Honk() {

    }
}

// Derived class
public class Car : Automobile {

    public string UseEmergencyBreak() {

        SqueezeBreakPads();
        return "skreeech!";
    }
}