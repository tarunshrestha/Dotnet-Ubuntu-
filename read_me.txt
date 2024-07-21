# Ubuntu because it doesnot have Visual Studio 

Extra:
    dotnet -h
    dotnet info
    dotnet --version
    dotnet build # To build


1. Create and Run project:
    dotnet new console -o app
    cd app
    dotnet run


2. MVC project Create:
    mkdir <ProjectName> 
    cd <ProjectName> 
    dotnet new mvc
    dotnet run


# For Postgres:
  In appsetting.json write:
    "ConnectionStrings": {
        "DefaultConnection": "Host=localhost;Database=AmazonBooks;Username=postgresql;Password=12345678"
    }

    Then install ( dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL)


# Install Entity core:
    View > Command Palette > NuGet Package
