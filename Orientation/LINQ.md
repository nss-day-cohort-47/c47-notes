## What is a Query?

A query is a broad term to encompass the concept of searching, filtering, and the transformation of data.

## What do we mean by data?

When using LINQ we are going to be working with collections of objects, strings, ints, etc.

Say you are working on a site like Medium.

Medium works with articles that the users create and put out.

All articles on medium are articles yet all of them are different and unique.

Article would be the class and each individual article would be an object.

You can create collections of articles and have access to all of their properties.

### What are some properties an article would have?

* Id
* Author
* Title
* Body
* Word Count
* Date it was posted


```cs
public class Article
{   
    public int Id {get; set;}
    public string Author{ get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public int WordCount {get; set;}
    public DateTime DatePosted {get; set;}
}
```

## Similar Concept to SQL

But say we want a collection of articles that the author was Christine?

Many times if we pull this data from an API we will have the option to write a SQL query or a similar query to filter the data we get by say Author.

However, that is not always the case. Sometimes APIs don't have the options we need and sometimes data comes from other sources that dont have those options at all.

When we need to sort data that we have recieved that cant be sorted beforehand we can use LINQ.

## Examples of data sources
* API
* txt file
* csv file
* etc

## What is LINQ?

LINQ is Language-INtegrated Query

Contained withing the ``` System.Linq ```

A set of methods that allow for the searching, filtering, and transforming collections.

## LINQ Methods

A lot of what you will see will look a lot like similar methods you used in Javascript

### Finding and Filtering

#### FirstorDefault()

This method will return the first instance of entity that matches your conditions, but unlike other similar methods if nothing is found it will return the default value for the type.
##### Example
```cs
Article first = articles.FirstOrDefault(a => a.Author == "Andy");

```
JavaScript equivalent
```js
.Find()
```


#### Skip

This method skips a specified number of items in the collection and then returns the rest.

##### Example

```cs
List<Article> skipFirstTwo = articles.Skip(2).ToList();
```

##### JavaScript Equivalent

_there is no JavaScript equivalent_

---

#### Take

This method returns the given number of objects from the collection starting at the beginning.

##### Example

```cs
List<Article> firstTwo = articles.Take(2).ToList();
```

##### JavaScript Equivalent

_there is no JavaScript equivalent_

---

#### Where

This method returns all objects that match a given condition.

##### Example

```cs
List<Article> articlesAbove500 = articles.Where(a => a.WordCount > 500).ToList();
```

##### JavaScript Equivalent

filter()

---

### Transforming Data

#### Select

This method converts a collection of objects of one type into a collection of objects of another type.

##### Example

```cs
List<string> authors = articles.Select(a => a.Author).ToList();
```

##### JavaScript Equivalent

map()

---

### Sorting and Reversing

#### OrderBy

This method returns a new collection of objects sorted by the given expression.

##### Example

```cs
List<Article> sortByDatePosted = articles.OrderBy(a => a.DatePosted).ToList();
```

##### JavaScript Equivalent

sort()

---

#### OrderByDescending

This method is like `OrderBy`, but sorts in the opposite direction.

##### Example

```cs
List<Article> sortByDatePostedDescending = articles.OrderByDescending(a => a.DatePosted).ToList();
```

##### JavaScript Equivalent

sort()

---

### Inspecting a Collection

#### All

This method returns true if every object meets a given condition.

##### Example

```cs
bool areAllWordCountsAboveZero = articles.All(a => a.WordCount > 0);
```

##### JavaScript Equivalent

every()

---

#### Any

This method returns true if at least one of the objects meets a given condition.

##### Example

```cs
bool hasBrenda = articles.Any(a => a.Author == "Brenda");
```

##### JavaScript Equivalent

some()

---

#### Contains

This method returns true if the collection contains the given object.

##### Example

```cs
List<int> wordCount = articles.Select(a => a.WordCount).ToList();
bool hasNineFifty = wordCount.Contains(950);
```

##### JavaScript Equivalent

includes()

---

### Numbers and Math

#### Average

This method finds the average value of a given property in a collection.

##### Example

```cs
double avgWordCount = articles.Average(a => a.WordCount);
```

##### JavaScript Equivalent

_there is no JavaScript equivalent_

---

#### Max

This method finds the maximum value of the given property within the collection.

##### Example

```cs
double maxWordCount = articles.Max(a => a.WordCount);
```

##### JavaScript Equivalent

_there is no JavaScript equivalent_

---

#### Min

This method finds the minimum value of the given property within the collection.

##### Example

```cs
int minWordCount = articles.Min(a => a.WordCount);
```

##### JavaScript Equivalent

_there is no JavaScript equivalent_

---

#### Sum

This method sums the values of given property in each object.

##### Example

```cs
int totalWordCount = articles.Sum(a => a.WordCount);
```

##### JavaScript Equivalent

_there is no JavaScript equivalent_

---



## IEnumberable

IEnumerable is as you may guess an interface. 

A central place for LINQ methods and all LINQ methods implement this. 

Don't think too hard about and its restrictive.

## LINQ Query Syntax

When first introduced LINQ's creators thought that if developers could associate it with SQL it would be easier to understand. 

Many of the names of methods you saw are similar to SQL as well.

Even the structure can be similar.

```cs
List<string> recentArticles = (
    from a in articles
    where a.DatePosted.Month == 6
    select $"Author: {a.Author} Title: {a.Title} Date: {a.DatePosted}"
).ToList();
```

You may see some like this while out on the job.

An alternative to SQL is entity framework which employs a similar idea, but we will not be using it in this course.