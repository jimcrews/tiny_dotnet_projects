# .NET Core Dependency Injection Lifetimes Explained

<i>use 'dotnet run' to see the logging information

## Transient Lifetime
If in doubt, make it transient. That’s really what it comes down to. Adding a transient service means that each time the service is requested, a new instance is created.

## Singleton Lifetime
A singleton is an instance that will last the entire lifetime of the application. In web terms, it means that after the initial request of the service, every subsequent request will use the same instance. This also means it spans across web requests (So if two different users hit your website, the code still uses the same instance).

## Scoped Lifetime
Scoped lifetime objects often get simplified down to 'one instance per web request', but it’s actually a lot more nuanced than that. Admittedly in most cases, you can think of scoped objects being per web request. So common things you might see is a DBContext being created once per web request, or NHibernate contexts being created once so that you can have the entire request wrapped in a transaction. Another extremely common use for scoped lifetime objects is when you want to create a per request cache.

Scoped lifetime actually means that within a created 'scope' objects will be the same instance. It just so happens that within .net core, it wraps a request within a 'scope', but you can actually create scopes manually.