# Relational Databases and SQL

## json-server

* not a database
* a json file is also not a database
  * is a way to store data

## Relational Databases

* Composed of Tables and Relationships between those tables
* Table
  * Rows (records)
    * each row is one "object" of data
  * Columns
    * names and data types
    * specify the properties of each record
  * a "grid" of data
  * a collection of records
* Relations
  * Each table will have a primary key
    * auto-incrementing identifier
    * probably called `id`
  * Tables may have foriegn keys that refer to other tables' primary keys
    * integers
    * `<table_name>Id`
  * No "nested" data
    * data is related only through keys
* Data Types
  * varchar - string
  * integer - int
  * datetime - datetime
  * bit - boolean
  * float - double / decimal
  * Any type can be NULL
* non-relational databases
  * AKA NoSql databases
    * we won't be talking about them

## Tools and Technologies

* SQL Server
  * The database we'll be using
  * Microsoft database (RDBMS (Relational Database Management System))
  * Container for databases
    * A database is a container of tables
      * A table is container of rows (records)
        * A row is a container or properties (columns)
  * We use the "Express" edition
    * used for development
  * Popular RDBMS
    * especially for ".net dev shops"

* Other Relational Databases
  * Oracle
  * MySQL
  * PostreSQL

* SQL Server Clients
  * We'll use Visual Studio as a client
  * others
    * SQL Server Management Studio
      * most popular
    * Azure Data Studio

## SQL

* Structured Query Language
* SQL is the language used to interact with relational databases
* SQL provides mechanisms for doing all the CRUD operations
  * Create - `INSERT`
    * ex: `INSERT INTO Artist (ArtistName, YearEstablished) VALUES ('The Cure', 1977);`
  * Read - `SELECT`
    * ex: `SELECT Id, ArtistName, YearEstablished FROM Artist WHERE YearEstablished = 1977;`
  * Update - `UPDATE`
    * ex: `UPDATE Artist SET YearEstablished = 1978 WHERE ArtistName = 'The Cure';`
  * Delete - `DELETE`
    * ex: `DELETE FROM Artist WHERE ArtistName = 'The Cure';`
* The most complex operation is `SELECT`
  * used to query data from one or more tables
  * tables are combined using the `JOIN` keyword
  * the `WHERE` keyword is used to filter results
  * The result of a `SELECT` is a grid of data called a "result set"
    * It _looks_ like a table, but it isn't a table
    * Tables are permanent storage, result sets are ephemeral
