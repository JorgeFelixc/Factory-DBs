using Factory.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Core
{
    public interface IDaoFactory
    {
        IActions _actions { get; }
    }
}
