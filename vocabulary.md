# Vocabulary

## C#

* Type
  * Set of constraints on values and variables
  * The type of a value specifies what kind of thing it can be
  * The type of a variable specifies what kind of thing can be stored in the variable
  * Examples
    * `int`
    * `decimal`
    * `double`
    * `bool`
    * `List<string>`
    * `List<int>`
    * `List<Person>`
    * `Dictionary<string, bool>`
    * `string`
  * In C# we can create custom types using classes
    * A `Person` class gives us the ability to create variables and values of type `Person`
* Class
  * Creates a new type
  * Defines the "shape" of an object
    * defines the properties and methods that an object will have
      * public properties and and methods are called "members"
  * Where do classes live?
    * inside our source code (`*.cs`)
  * Blueprint for creating objects
    * a "class" is like the blueprint
    * an "object" is like the house
  * Class is like cookie cutter, object is like the cookie
* Object
  * The "real" value that exists at runtime
  * Where do objects live?
    * Inside the running program
  * Objects have value
  * Object contain the properties, fields and methods defined in the class
* Constructor
  * Is a special method defined inside the class that is invoked when an object is created
  * Has the same name as the class
  * Does NOT have a return type
  * Invoked when you use the `new` keyword
  * You don't have to define a constructor (if you don't need one)
    * If you don't define a constructor, C# will automatically create one for you
      * Called the "Default Constructor"
      * It does nothing other than create the object
    * Define a constructor when you need to perform some kind of action when an object is created
      * maybe some logic
      * maybe some field or property initialization
* Method
  * Defined in a class
  * Exists in an object
  * Function that does something on or to the object
    * within the context of an object
* Property
  * Value/Data on an object
  * Defined in a class
  * Exists in an object
  * Has a type
  * Properties are often `public`
  * Always have a `get`
    * return the value
  * Usually have a `set`
    * to update the value
    * without a set, the value is "read only"
      * you can't change it
      * it's "immutable"
  * Properties are one way of containing the "state" of that object
* Field
  * Anther way to store data on an object
  * Usually `private`
  * Used when you only need the value inside of the object and not by any other part of your code
    * Called "Encapsulation"

