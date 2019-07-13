using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Domain.Interfaces
{
    public interface IActions
    {
        string ConectionString { get; set; }
        string Database { get; set; }

        bool Add(object entitie);

        bool Delete(object entitie);

    }
}
