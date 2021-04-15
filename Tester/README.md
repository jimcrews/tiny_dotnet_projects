The NUnit test project templates need to be installed before creating a test project. This only needs to be done once.

```
dotnet new -i NUnit3.DotNetNew.Template
```

1. Create solution folder, then inside the folder:

```
dotnet new sln --name TesterSolution
```

2. Create the Console App Folder, then inside the folder:

```
dotnet new "Console Application"
```

3. Create the Class Library Folder, then inside the folder:

```
dotnet new classlib
```

4. Create the Tests Folder, then inside the folder:

```
dotnet new nunit
```

```
Tester
|-- README.md
|-- TesterSolution.sln
|-- consoleApp
|   |-- Program.cs
|   |-- consoleApp.csproj
|-- lib
|   |-- Class1.cs
|   |-- lib.csproj
`-- tests
    |-- UnitTest1.cs
    `-- tests.csproj
```

5. Add all 3 projects into the solution:

```
dotnet sln add consoleApp/consoleApp.csproj
dotnet sln add lib/lib.csproj
dotnet sln add tests/tests.csproj
```

6. Add Project References:

```
dotnet add tests/tests.csproj reference consoleApp/consoleApp.csproj
dotnet add tests/tests.csproj reference lib/lib.csproj
dotnet add consoleApp/consoleApp.csproj reference lib/lib.csproj
```

7. Run tests

```
dotnet test
```
