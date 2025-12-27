🚀 User Authentication Backend API
---

A secure and scalable ASP.NET Core Web API for user authentication using JWT, Entity Framework Core, and SQL Server.
Built to work seamlessly with a React frontend.

📌 Tech Stack
--

.NET 8 – ASP.NET Core Web API

Entity Framework Core

SQL Server

JWT Authentication

Swagger / OpenAPI


📦 NuGet Packages Used
--
Microsoft.AspNetCore.Authentication.JwtBearer
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
Swashbuckle.AspNetCore


🔐 Main Functionalities
--

User Registration (with password hashing)

User Login with JWT Token generation

Secure APIs using JWT Authentication

Swagger API Documentation

Clean architecture using DTOs & Services


🔑 Authentication Flow
--
Register → Login → Receive JWT → Access Protected APIs



🧬 Entity Framework Migrations
--
Add Migration
dotnet ef migrations add InitialCreate

Update Database
dotnet ef database update

Generate SQL Script
dotnet ef migrations script


🧪 Run the Project
--
dotnet restore
dotnet build
dotnet run


Swagger URL:

http://localhost:<port>/swagger



🗄️ Database & Tables Creation Script (SQL Server)
--
1️⃣ Create Database


CREATE DATABASE UserAuthDb;




2️⃣ Use Database



USE UserAuthDb;




3️⃣ Create Users Table


CREATE TABLE Users (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(150) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL,
    CreatedAt DATETIME2 NOT NULL DEFAULT GETDATE()
);




4️⃣ Insert Sample User (Testing)

⚠️ PasswordHash below is sample only



INSERT INTO Users (FullName, Email, PasswordHash)
VALUES (
    'Test User',
    'test@example.com',
    'AQAAAAIAAYagAAAAEFxJ3W...' -- Password@123  
);



