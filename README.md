Sakila Actor Movie Finder
A simple, direct implementation of ADO.NET in C# to interact with the classic Sakila sample database. This project demonstrates how to use SqlConnection and SqlCommand to perform multi-table joins and retrieve relational data based on user input.

Features
 * Live Database Querying: Uses Microsoft.Data.SqlClient to communicate with SQL Server.
 * Complex Joins: Executes a 3-table join (Film ↔ film_actor ↔ Actor) to map stars to their movies.
 * User Interactive: Takes real-time console input to filter results.
 
 Setup & Requirements
 * Database: You need the Sakila database installed on your (localdb)\MSSQLLocalDB.
 * Connection String: Check the connection string in Program.cs. You may need to update the Data Source if your SQL instance named differently.
 * NuGet Packages: Ensure Microsoft.Data.SqlClient is installed in your project.
 
 How to Use
 * Run the application.
 * Enter the First Name and Last Name of an actor (e.g., "Nick" "Stallone").
 * The app will return a formatted list of all movies associated with that actor.
> [!TIP]
> A Note on Security: This project is a great learning exercise for ADO.NET basics! Just a heads-up: it currently uses string interpolation for the SQL query. If you were taking this to a "real-world" project, you'd want to switch to Parameterized Queries to prevent SQL injection. It’s a small change that makes a huge difference in security!
