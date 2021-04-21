using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BusinessAccess
    {
        private IDataAccess _dataAccess;
        public BusinessAccess(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void RunBusinessProcess()
        {
            _dataAccess.Store("Business Data");
        }
    }
}
