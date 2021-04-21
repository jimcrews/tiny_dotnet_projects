using System;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new ServiceCollection();
            collection.AddTransient<IDataAccess, DataAccess>();

            var provider = collection.BuildServiceProvider();
            IDataAccess dal = provider.GetService<IDataAccess>();

            BusinessAccess biz = new BusinessAccess(dal);
            biz.RunBusinessProcess();
        }
    }
}
