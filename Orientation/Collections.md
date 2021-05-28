#Collections

What is a collection?

In broad terms it's an object that stores things

Javascript examples would be Arrays and Objects.

Where arrays order items in order and can be accessed by index, the objects had string keys attached to a value.

#List 

Something you will have seen already is List<>.

While C# also has arrays, Lists are much easier to add and remove entries. 

You dont have to say how long a list will be. Its length is dynamic.


```cs

int[] array = new int[4];

or

int[] array = new int[] {1,2,3,4};

```
The arrays length is set to 4 here when it is created.

The List, however, has a dynamic length and , therefore, is more useful when taking in information of varying quantities.

Lists are found in the ``` System.Collections.Generic ``` namespace.

```cs
using System.Collections.Generic
```
###Creation of a List
```cs
List<int> test = new List<int>()
{
    1,2,3,4,5,6,7,8,9,10
};

List<int> test = new List<int>();
```

List also come with a wide range of methods to use on them.

##Some examples being:


###Add:

Add lets you add an item to the end of the array.
```cs
test.Add(11);
```
###AddRange:

AddRange lets you add a series of entries such as another list to your list at once.
```cs
test.AddRange(test);
```
###Insert:

Insert places the object at the specified index and moves the rest of the items down one index.
```cs
test.Insert(2, 25);
```
###Find:

Find searches for the first instance of the item.
```cs
Console.WriteLine(test.Find(x => x == 4));
```
###Remove:

Removes the first instance of the item.
```cs
test.Remove(7);
```
###Contains:

Contains returns true or false if the List contains the item.
```cs
if(test.Contains(8))
{
    Console.WriteLine("Test contains 8");
};
```
###Count:

Count is how many items are contained in the list.
```cs
Console.WriteLine(test.Count);
```
###Capacity:

Capacity is how large the List can be before it resizes.
```cs
Console.WriteLine(test.Capacity);

```
#Dictionary

Dictionaries are another example of collections similar to Javascript objects.

They consist of key, value pairs and are can be used to quickly find items within and prevent duplicates among other things.



##Example of a Dictionary:
```cs
Dictionary<string, int> fastFoodCount = new Dictionary<string, int>()
{
    {"McDonalds", 45},
    {"Burger King", 25},
    {"Wendy's", 17},
    {"Taco Bell", 88}
};
```

Dictionaries also have the add method:

```cs
fastFoodCount.Add("Arby's", 76);
```
Dictionaries also have the as well as other similar methods:

```cs
if(fastFoodCount.ContainsKey("Taco Bell"))
{
    Console.WriteLine("fastFoodCount contains Taco Bell");
};
```

Like Lists you can iterate through Dictionaries as well. However the syntax is a bit different.

```cs
foreach (KeyValuePair<string, int> store in fastFoodCount)
{
    Console.WriteLine($"There are {store.Value} {store.Key} in the area.");
}
```


###IEnumerable

There is another type of collection called IEnumerable which is used by a lot of LINQ methods. It functions a lot like a list but isn't as versatile.

IEnumerable has a method that it can be changed into a list however ```.ToList()```.

```cs
IEnumerable<string> patients = data.GetPatients();
List<string> patientList = patients.ToList();
```

This is often used to convert an IEnumerable to a lsit after the LINQ methods are completed.

LINQ methods are queries that can be used to sort data ina multitude of ways. We will learn more about these later in the class.