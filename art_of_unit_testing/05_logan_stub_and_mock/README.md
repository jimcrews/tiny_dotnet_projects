## Using Stub and Mock

In this test, we have two fakes. One is the email service mock, which we use to verify that the correct parameters were sent to the email service. The other is a stub that we use to simulate an exception thrown from the web service. It’s a stub because we won’t be using the web service fake to verify the test result, only to make sure the test runs correctly. The email service is a mock because we'll assert against it that it was called correctly.

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
