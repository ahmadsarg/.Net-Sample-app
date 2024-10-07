# .Net-Sample-app
ASP.NET Core 3-Tier Architecture CRUD Application with Entity Framework

This project is a simple CRUD (Create, Read, Update, Delete) web application built with ASP.NET Core MVC using Entity Framework Core as the ORM (Object Relational Mapper). It follows the 3-tier architecture:

Presentation Layer: The user-facing layer, built using ASP.NET Core MVC. It handles the user interface (UI) and HTTP requests.
Business Logic Layer (BLL): This layer contains the application logic. It communicates between the Presentation Layer and the Data Access Layer, applying business rules.
Data Access Layer (DAL): This layer uses Entity Framework Core to interact with the database, manage product information, and persist changes to the database.
The application allows users to perform basic operations on products:

Create new products.
Retrieve and view all products.
Edit product details.
Delete products.
The application uses SQL Server (LocalDB or any other instance) for the database, with Entity Framework Core handling the database communication.
