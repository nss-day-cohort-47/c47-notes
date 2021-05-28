# Exceptions

C# is different to javascript when one gets an error. Javascript tends to tell you hey theres a problem but c# will let you know a lot more information.

### Lets see what an exception looks like.

```cs
    string test = "number";
    int answer = int.Parse(test);
        
              
    Console.WriteLine("Oops something went horribly wrong!");

```

### Here's an example of an exception.
```
Unhandled exception. System.FormatException: Input string was not in a correct format.
   at System.Number.ThrowOverflowOrFormatException(ParsingStatus status, TypeCode type)
   at System.Number.ParseInt32(ReadOnlySpan`1 value, NumberStyles styles, NumberFormatInfo info)
   at System.Int32.Parse(String s)
   at teaching.ExceptionTest.Exceptions() in C:\Users\hilli\workspace\teaching\ExceptionTest.cs:line 11
   at teaching.Program.Main(String[] args) in C:\Users\hilli\workspace\teaching\Program.cs:line 11
```
What parts of an exception are really important for us to see?

1. What kind of exception? System.FormatException

2. What happened? Input string was not in a correct format.

3. Where it happened? ExceptionTest.cs:line 11, Program.cs:line 11

```cs
try
{

    string test = "number";
    int answer = int.Parse(test);

}
catch(FormatException ex)
{

    Console.WriteLine("You have a formatting exception!");

}

```
Try Catch is not a bandaid to fix bad code!

Think about the errors!

### Try another example of an exception.

```cs
    List<string> dataEntries = new List<string>()
    {
        "Andy", "Tyler", "Christine"
    };
    List<int> indexes = new List<int>()
    {
        0,2,15
    };
           
    foreach (int index in indexes)
    {
        Console.WriteLine(dataEntries[index]);
    }
```

### The exception:

```
Unhandled exception. System.ArgumentOutOfRangeException: Index was out of range. Must be non-negative and less than the size of the collection. (Parameter 'index')
   at System.Collections.Generic.List`1.get_Item(Int32 index)
   at teaching.ExceptionTest.Exceptions() in C:\Users\hilli\workspace\teaching\ExceptionTest.cs:line 21
   at teaching.Program.Main(String[] args) in C:\Users\hilli\workspace\teaching\Program.cs:line 11

```

1. What kind of exception? 

2. What happened? 

3. Where it happened?

What can we do with try catch to fix this?


Questions??
