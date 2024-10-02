# poc.ef.mysql
This project is using code-first and database-first with .NET8 + EF Core + MySQL

# Dockerfile
![image](https://github.com/user-attachments/assets/267ce9e0-4eb0-41fc-83a4-ac95be89194d)

# docker-compose
![image](https://github.com/user-attachments/assets/834c9726-7ca1-4723-a32b-a280e95e0aeb)

# docker containers running
![image](https://github.com/user-attachments/assets/082abe68-eb39-4c24-b3f0-683b7f22259f)


# -------------------- DATABASE FIRST ----------------

# ER diagram
![image](https://github.com/user-attachments/assets/c36f18c6-7998-45a0-98df-122ef408a147)

# SQL Script
![image](https://github.com/user-attachments/assets/c1fd3e60-b0a8-495e-9b35-7ad7040253d1)

# Adminer container running
![image](https://github.com/user-attachments/assets/c7effa2c-edd0-410c-b0c7-a836574375ac)
![image](https://github.com/user-attachments/assets/59a19eb9-bd3a-4e93-96b8-4a288afe84a6)

# Commands to execute Database first
1. Install Required Packages
First, you need to install the required Entity Framework Core packages for MySQL.
 - dotnet add package Pomelo.EntityFrameworkCore.MySql
 - dotnet add package Microsoft.EntityFrameworkCore.Design

2. Install EF Core Tools
To use the dotnet ef commands, ensure that the Entity Framework Core tools are installed globally:
 - dotnet tool install --global dotnet-ef
If you already have the EF Core tools installed, update them to ensure compatibility with .NET 8:
 - dotnet tool update --global dotnet-ef

3. Scaffold MySQL Database into Models
Use the dotnet ef dbcontext scaffold command to generate the entity classes and the DbContext from your MySQL database.
- dotnet ef dbcontext scaffold "Server=poc.mysql;Database=classicmodels;User=myuser;Password=123;" Pomelo.EntityFrameworkCore.MySql -o Models -c MyDbContext

# Models were generated from Database
![image](https://github.com/user-attachments/assets/1e47a7f6-3c79-4c0d-8876-c5a1787118ad)

![image](https://github.com/user-attachments/assets/a976c238-369d-428a-a8fc-267f0ef898c5)


-------------------- CODE FIRST ----------------

# Setting up the EF Core on program.cs of a console application
![image](https://github.com/user-attachments/assets/e4d87bd5-7320-457c-ab15-e1a3d54a91ff)

# Db Context
![image](https://github.com/user-attachments/assets/e7bc640e-9abb-4e1d-a437-49cce2b34798)

# Fluent Api Mapping
![image](https://github.com/user-attachments/assets/43732c8b-2287-4a06-9643-1a8ac694d5d6)

# Commands to execute Data-First (Migrations)
 - dotnet ef migrations add InitialCreate -c MyDbContext

![image](https://github.com/user-attachments/assets/74bb2cf6-30a7-443a-a3ba-ef6ec21dddde)
![image](https://github.com/user-attachments/assets/bf392659-f256-4c5b-af7d-cfb79b1fb6ae)


