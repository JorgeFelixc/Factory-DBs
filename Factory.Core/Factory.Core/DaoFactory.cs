using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Core
{
    public class DaoFactory
    {

        public IDaoFactory GetDataObject(string provider)
        {
            switch (provider.ToLower())
            {
                case "sql": return new SQL.DataObject();
                case "mongodb": return new MongoDB.DataObjects();
                default: return null;
            }
        }
    }
}
