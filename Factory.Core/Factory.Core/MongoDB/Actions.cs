using Factory.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Core.MongoDB
{
    class Actions : IActions
    {
        public string ConectionString
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Database
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool Add(object entitie)
        {
            throw new NotImplementedException();
        }

        public bool Delete(object entitie)
        {
            throw new NotImplementedException();
        }
    }
}
