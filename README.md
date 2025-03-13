# Footballer Management System

## Overview
Footballer Management System is a .NET Framework 4.8 application that demonstrates database access using ADO.NET. The application includes a data access layer (DAL) for executing SQL queries and commands, and a simple Windows Forms application for user interaction.

## Project Structure
The project consists of the following files:

- `DALGen.cs`: Contains the abstract class `DALGen` which provides methods for database connection and executing SQL commands.
- `Program.cs`: The main entry point for the application.
- `Properties/AssemblyInfo.cs`: Contains metadata about the assembly.

## Getting Started

### Prerequisites
- Visual Studio 2022
- .NET Framework 4.8
- SQL Server

### Setup
1. Clone the repository to your local machine.
2. Open the solution in Visual Studio 2022.
3. Update the connection string in `DALGen.cs` to match your SQL Server configuration.
4. Build the solution to restore the necessary NuGet packages.

## Usage
The application starts with a login form. After logging in, you can interact with the database using the methods provided in the `DALGen` class.

## Methods in DALGen
- `CreateConnection(ref string errMess)`: Creates a new database connection.
- `ExecuteReader(string sQuery, ref string errMess)`: Executes a SQL query and returns a `SqlDataReader`.
- `ExecuteDS(string query, List<SqlParameter> parameters, ref string errMess)`: Executes a SQL query and returns a `DataSet`.
- `ExecuteNonQuery(SqlCommand command, ref string errMess)`: Executes a SQL command that does not return any data.
- `ExecuteScalar(SqlCommand command, ref string errMess)`: Executes a SQL command and returns a single value.
