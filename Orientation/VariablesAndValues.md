# Variables and Values

## In JavaScript

```js
// theAnswer is the variable
// 42 is the value

let theAnswer = 42; // integer
theAnswer = "Hello!"; // string

// The expression on the right-hand side of the assignment operator (=) 
//  is evaluated to produce a value BEFORE the value is stored in the variable.
let x = 1 + 1;
```

## In C#

```cs

// In C# both variables and values have "types"

int theAnswer = 42;
theAnswer = 2

theAnswer = "Hello"; // this is an error in C#

int x = 1 + 1;

string msg = "Hello, World!";

// It's possible to declare a variable on one line and assign it later in the program
bool isTrue;
// ...
isTrue = false;

// The List<> type comes from the System.Collections.Generic namespace
// A List<string> can only contain strings
List<string> groceryList = new List<string>() {
  "milk", "eggs", "beer", "bacon"
};
```

## Notes

* Value
  * a specific "thing" that the program is working with
  * stored somewhere in the computer's memory
  * software makes decisions based on values
    * conditionals
    * loops
  * examples
    * `42`, `1`, `3.3`
    * `"hello"`, `"Fred"`
    * `true`, `false`
    * `null`

* Variable
  * named container for a value
  * place to store a value to be used later
  * use the variable name to get to the value it contains

* Assignment Statement
  * one way we get a value into a variable
  * uses the `=` sign
  * the variable is on the left-hand side
  * the value is an *evaluated expression* on the right-hand side
  * Another area where a variable receives a value is in a function parameter

* Types
  * In javascript the *value* has a type, but the *variable* doesn't
  * In C# BOTH the *value* and the *variable* have types
    * a variable in C# can only contains values of ONE type
    * the type of the variable is specified when the variable is created

