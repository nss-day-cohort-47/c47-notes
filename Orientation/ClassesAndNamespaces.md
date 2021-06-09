# Common Structure of a C# Program

## Namespaces

* A namespace is a named container for classes
  * has a name
  * use a namespace in more than one c# (`*.cs`) file
  * namespace name matches project name
  * to access classes in a namespace we use the `using` directive
    * a `using` is kinda like an `import` in JavaScript

## Classes

* Classes...
  * a way to create custom "types" in C#
  * used to create an object
    * like a factory function in javascript
  * class is a blueprint for an object
  * use the `new` keyword to construct a new object from a class
  * ex: `Diary myDiary = new Diary();`
* Classes vs Objects
  * Class defines the properties and methods of an object
  * Object is the "real" thing in our program
  * the difference is analogous to the difference between a blueprint and a house
    * YOU CAN'T LIVE IN A BLUEPRINT

* Constructor
  * the "special method" that is used to construct an object
  * executed when creating a `new` instance of the class
  * has the *same name* as the class
  * does NOT specify a return type (not even `void`)

* Properties
  * define locations to store data in an object
  * defined with a `{ get; set; }`
  * *usually* are marked as `public`

* Methods
  * "functions" on an object
  * a method is defined in a class
  * a method is called on an object
  * add behavior to an object

* Fields
  * another way of storing data in an object
  * does NOT have a `{get; set;}`
  * *usually* private
  * *usually* start with an "_"

* Class / Object Relationships
  * Inheritance
    * parent / child relationship
    * `is-a` relationship
      * An `Instructor` object is-a `Person`
      * one-way relationship
        * A `Person` object is not necessarily an `Instructor`

  * Association
    * Usually we use the term "composition"
    * Objects are related in some way
    * `has-a` relationship
      * one object contains an instance of another
    * "prefer composition over inheritance"
      * as a way to reuse code

* `static`
  * a keyword used to mark a method or property as something that can be used without instantiating an object.
  * Use the class name to invoke a `static` method
    * ex: `StringUtil.Capitalize("word");`

* overloading
  * the term "overloading" refers to having multiple methods with the same name.
  * overloaded methods are distinguished by the number and types of parameters.
  * overloading is often conflated with _overriding_

* Access Modifiers
  * `public`, `private`, `protected`
  * used to indicate how accessible a method, property or field is.
  * `public` can be accessed by any other code
  * `private` can only be accessed within the class
  * `protected` like private, but can also be accessed by child classes.

### Classes are like Factory Functions in JavaScript

A class in C# is like a "factory" function in JavaScript. Both are used to construct new objects

#### JavaScript

##### Defining the factory function

```js
const newDiary = (owner) => {
  const diary = {
    owner: owner,
    creationDate: new Date(),
    entries: []
  };

  return diary;
};
```

##### Using the factory function

```js
const myDiary = newDiary("Andy");
const tylerDiary = newDiary("Tyler");
```

#### C#

##### Defining the class

```cs
public class Diary
{
    public Diary(string owner)
    {
        Owner = owner;
        CreationDate = DateTime.Now;
        _entries = new List<string>();
    }

    public string Owner { get; set; }
    public DateTime CreationDate { get; set; }
    public List<string> Entries { get; set; }
}
```

##### Using the class

```cs
Diary myDiary = new Diary("Andy");
Diary myDiary = new Diary("Tyler");
```

## [Example C# project - Diary](./DiaryProject)


