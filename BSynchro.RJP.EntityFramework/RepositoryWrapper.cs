using BSynchro.RJP.Domain.irepositories;
using BSynchro.RJP.EntityFramework.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSynchro.RJP.EntityFramework
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private BSynchroRJPDbContext _repoContext;
        private ICustomerRepository _customer;
        private IAccountRepository _account;
        public ICustomerRepository Customer
        {
            get
            {
                if (_customer == null)
                {
                    _customer = new CustomerRepository(_repoContext);
                }
                return _customer;
            }
        }
        public IAccountRepository Account
        {
            get
            {
                if (_account == null)
                {
                    _account = new AccountRepository(_repoContext);
                }
                return _account;
            }
        }
        public RepositoryWrapper(BSynchroRJPDbContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
