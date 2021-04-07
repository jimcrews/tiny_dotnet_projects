# Tiny .NET Projects

<br />

## BethanysPieShop

> .NET (Core) 5.0, with EF 5.0 using SQLite backend

### Development Tooling

> Arch Linux and the DotNet CLI

- ASP.NET MVC
- Entity Framework
- LibMan

### Setup

```
# create empty ASP.NET app

dotnet new web

# install LibMan, and initialize LibMan in the project

dotnet tool install -g Microsoft.Web.LibraryManager.Cli

libman init

```

```
# install client libraries

libman install jquery@3.4.1 --provider cdnjs --destination wwwroot/lib/jquery

libman install twitter-bootstrap@3.3.7 --provider cdnjs --destination wwwroot/lib/bootstrap

```

```
# install entity framework tools

dotnet tool install --global dotnet-ef

# create the initial migration and update

dotnet ef migrations add InitialMigration
dotnet ef database update

```

Content delivery at its finest -> https://cdnjs.com/libraries

---
