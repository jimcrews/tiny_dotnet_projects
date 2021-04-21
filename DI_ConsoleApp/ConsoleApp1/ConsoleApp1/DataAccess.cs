using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DataAccess : IDataAccess
    {
        public void Store(string data)
        {
            // write the data to the database
            Console.WriteLine("Storing some data..");
            Console.WriteLine(data);
            Console.WriteLine("-------------------");
        }
    }
}
