# The `var` keyword in C#

When declaring a `string` variable in C#, you might do something like this:

```cs
string name = "Lucy";
```

When declaring a `List<int>` variable in C# you might do something like this:

```cs
List<int> bowlingScores = new List<int>();
```

You might find the code in the above scenarios to be a bit redundant....because it is. In each case it's obvious from the right-hand side of the `=` what the time of the variable should be. So why do we have to spell it out?

Turns out, we don't.

That's where the `var` keyword comes in. The above code could be written like this:

```cs
var name = "Lucy";

var bowlingScores = new List<int>();
```

This code is exactly equivalent to the code above.

## When can you use `var`?

You can use var for _local variables_ where the variable is being assigned a value when it's being created.

You cannot use `var` for properties or fields.

You cannot use `var` when you aren't assigning a value to the variable right away.