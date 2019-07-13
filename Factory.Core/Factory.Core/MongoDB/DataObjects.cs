using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Domain.Interfaces;

namespace Factory.Core.MongoDB
{
    public class DataObjects : IDaoFactory
    {
        public IActions _actions { get { return new Actions(); } }

    }
}
