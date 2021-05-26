1. Create the Solution

```
mkdir 01_login
cd 01_login

dotnet new sln --name Logan
```

2. Create the Class Library

```
mkdir lib
cd lib/
dotnet new classlib
```

3. Create the NUnit Test Library

```
mkdir testsLib
cd testsLib/
dotnet new nunit
```

4. Add projects into the Solution

```
dotnet sln add testsLib/testsLib.csproj
dotnet sln add lib/lib.csproj
```

5. Add Project Reference

```
dotnet add testsLib/testsLib.csproj reference lib/lib.csproj
```

6. Install NSubstitute to test project

```
dotnet add package NSubstitute --version 4.2.2
```
