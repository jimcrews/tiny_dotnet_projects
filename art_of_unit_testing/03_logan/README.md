Tell the factory class to return your fake dependency by setting a property. The member inside the factory class is fake; the class under test isn’t changed at all.

#### When you Should Use Property Injection

Use this technique when you want to signify that a dependency of the class under test is optional or if the dependency has a default instance created that doesn’t create any problems during the test.

<br />

---

<br />

1. Create the Solution

```

mkdir 01_login
cd 01_login

dotnet new sln --name Logan

```

2. Create the Console App

```

mkdir consoleApp
cd consoleApp/
dotnet new console

```

3. Create the Class Library

```

mkdir lib
cd lib/
dotnet new classlib

```

4. Create the NUnit Test Library

```

mkdir testsLib
cd testsLib/
dotnet new nunit

```

5. Add all 3 projects into the Solution

```

dotnet sln add consoleApp/consoleApp.csproj
dotnet sln add testsLib/testsLib.csproj
dotnet sln add lib/lib.csproj

```

6. Add Project References

```

dotnet add testsLib/testsLib.csproj reference consoleApp/consoleApp.csproj
dotnet add testsLib/testsLib.csproj reference lib/lib.csproj
dotnet add consoleApp/consoleApp.csproj reference lib/lib.csproj

```
