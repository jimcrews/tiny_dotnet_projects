# Tiny .NET Projects

<br />

## BethanysPieShop

> .NET (Core) 5.0, with EF 5.0 using SQLite backend

### Development Tooling

- ASP.NET MVC App spun up using .net cli command
- Entity Framework migrations managed by the .net cli

```
# create empty ASP.NET app

dotnet new web
```

```
# install entity framework tools

dotnet tool install --global dotnet-ef

# create the initial migration and update

dotnet ef migrations add InitialMigration
dotnet ef database update

```

requires

- wwwroot/lib/bootstrap v3.3.7
- wwwroot/lib/jquery v3.4.1

---
