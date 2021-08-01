1. Create New Solution in New Folder

```
dotnet new sln --name dotNetSolution1
```

2. Create Console Application

```
mkdir consoleApp
cd consoleApp/
dotnet new "Console Application"
```

3. Create Library Project

```
mkdir lib
cd lib/
dotnet new classlib
```

4. Add projects to the solution

```
dotnet sln add consoleApp/consoleApp.csproj 
dotnet sln add lib/lib.csproj
```

5. Add project references

```
dotnet add consoleApp/consoleApp.csproj reference lib/lib.csproj 
```