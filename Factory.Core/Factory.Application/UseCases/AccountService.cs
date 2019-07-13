using Factory.Core;
using Factory.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Application.UseCases
{
    public class AccountService
    {
        private string provider = "";

        private IDaoFactory _context;
        private IActions _actions;

        public AccountService()
        {
            _context = new DaoFactory().GetDataObject(provider);
            _actions = _context._actions;
        }


        public object GetAccountData()
        {
            _actions.Delete();
        }
        
    }
}
