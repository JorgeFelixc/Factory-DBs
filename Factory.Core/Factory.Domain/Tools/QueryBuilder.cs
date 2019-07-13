using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Factory.Domain.Tools
{
    public class QueryBuilder
    {
        private string _conectionString { get; set; }
        private string _database { get; set; }
        private string _field { get; set; }
        private string _relation { get; set; }
        private object _data { get; set; }
        private string _filter { get; set; }

        public QueryBuilder(string conectionString)
        {
            _conectionString = conectionString;
        }

        public QueryBuilder(object _object, string filter)
        {
            _data = _object;
            _filter = filter;
        }


        public List<string> GetData()
        {
            var ls = new List<string>();
            var propsData = _data.GetType().GetProperties();

            return null;
        }


    }
}


/* 1, N, 1-N
 *Scheme of query:
 * Normal GET:
 * TABLE_NAME/COLLECTION {
 *  -Values,
 *  -Values,
 *  -Values,
 *  -Values
 * },
 * 
 * 
 * Normal ADD:
 * TABLE_NAME/COLLECTION{
 *  Name:Value,
 *  Name:'Value',
 *  Name: new Object()
 * }
 * 
 * 
 * Normal Delete
 * TABLE {
 *  Name: Value
 * }
 * 
 * 
 * Normal Update 
 * TABLE{
 *  Name: Value
 * }
 * */