# Ubuntu because it doesnot have Visual Studio 

Extra:
    dotnet -h
    dotnet info
    dotnet --version
    dotnet build # To build 
    dotnet ef migrations add InitialDBSetup # To Make Migrate (like: makemigrations)
    dotnet ef database update # To Migrate 


    Dotnet-ef tool:
        dotnet tool install --global dotnet-ef
        dotnet ef --version (Check version) 



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
        "DefaultConnection": "Host=localhost;Database=AmazonBooks;Username=postgres;Password=12345678"
    }

    Then install ( dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL)
    Connection:
        builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
    To reset password: 
        sudo -u postgres psql
        ALTER USER postgres WITH PASSWORD 'new_password';



# Install Entity core:
    View > Command Palette (Control + SHift + P)
    Type:  
        NuGet Package Manager: Add Package
        Entity
        Microsoft.EntityFrameworkCore
        Select version
    Or: 
         dotnet add package Microsoft.EntityFrameworkCore
    For Tools:
         dotnet add package Microsoft.EntityFrameworkCore.Tools
         dotnet add package Microsoft.EntityFrameworkCore.Design
