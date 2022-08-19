using BSynchro.RJP.Domain.irepositories;
using BSynchro.RJP.Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSynchro.RJP.EntityFramework.repositories
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(BSynchroRJPDbContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
