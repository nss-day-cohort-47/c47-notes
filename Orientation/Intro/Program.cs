using System;

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