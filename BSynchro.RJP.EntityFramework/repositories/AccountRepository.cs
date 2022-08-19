using BSynchro.RJP.Domain.irepositories;
using BSynchro.RJP.Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSynchro.RJP.EntityFramework.repositories
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(BSynchroRJPDbContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
