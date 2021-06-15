# ADO<span>.</span>NET

Working with a database from C# applications

* Client / Server
  * Client is the "customer"
    * makes a **request**
    * initiates the communication
  * Server "owns" the data
    * returns a **response**
    * waits for a client request 
  * Analogy of a coffee shop
    * Customer is the client, workers are the server
  * In terms of C# / ADO.NET / Sql Server
    * The C# app is the client
      * makes requests for the database: "SQL statements"
    * Sql Server is the server
      * responds with data and/or number of rows updated
* Relational Database
  * place to store data in organized way
  * contains **tables** that have **relationships** between themselves
    * primary and foreign keys to connect tables
* Table
  * "bookshelves" for storing data
  * "grids" of data
    * rows and columns
* Row
  * an item or "record" in a table
  * an individual element of data
  * multiple rows make up a table
* Column
  * **properties** of each "object" (row or record) in the table
  * each column has a name and a data type
    * data types
      * `integer` -> int
      * `varchar` -> string
      * `bit`-> bool
      * `datetime` -> datetime
* ADO<span>.</span>NET
  * way we communicate between C# and a database server
    * umbrella term collection of classes that we use
  * Examples of **ADO<span>.</span>NET** classes
    * `SqlConnection`
      * The class that represents the database connection
      * Should create a connection inside a `using` block
      * Must call `Open()` before the connection can be used
      * Use the create a command object
    * `SqlCommand`
      * The class that represents a command (aka "request") to be sent to the database server
      * Should create a command inside a `using` block
      * The `CommandText` property contains the SQL to be executed in the database
      * The `Parameters` property is a collection that contains sql parameters needed by the SQL that's in the `CommandText`
      * Has three useful "ExecuteXXX" methods for executing the command in the database
        * `ExecuteReader` - executes a `SELECT` statement and returns a `SqlDataReader` object that contains the query's resultset
        * `ExecuteScalar` - executes an `INSERT` statement and returns the integer id that was assigned to the newly inserted record
          * This method _can_ do more things that return an `ID`, but that's the use we have for it in this class
        * `ExecuteNonQuery` - execute an SQL statement that doesn't return any results from the database
          * Most useful for `UPDATE`s and `DELETE`s
          * This method will return an integer that specifies the number of records updated, but we usually ignore that
    * `SqlDataReader`
      * This class provides access to the results of a `SELECT` query
      * `SqlDataReader.Read()` 
        * This method does two things
          * Returns a boolean value that indicates whether there is more data let to read or not
          * Sets the reader to read the next row of the result set
          * You must call `Read()` once before calling any of the `GetXXX` methods
      * `SqlDataReader.GetOrdinal()`
        * returns the index (aka "ordinal") position of the given column in the resultset
      * `SqlDataReader.GetString()`, `SqlDataReader.GetInt32()`, etc...
        * these methods return data for a given column from row that the reader is currently pointing to
* Connection String
  * The "URL" of a database
    * aka the "address" of a database
  * Client (C# app, Visual Studio, ec...) sends a request to this address
* Database Connection
  * The link between the database client and the database server
  * The "tunnel" that carries communication between client and server
  * Connections are created using a "connection string"
* Repository Class
  * kind of class we make to interact with a particular database table
  * has methods for doing CRUD operations
* Model Class
  * a class that represents a record in a database table
  * aka "data model"
  * contains properties that map to columns in a table
    * has same (or similar) names
    * has same data types
* SQL Parameter
  * A variable used within a SQL statement
  * Prefixed with an `@`. (ex: `@id`)
  * The value for a sql parameter is set by calling the `SqlCommand.Parameters.AddWithValue()` method
