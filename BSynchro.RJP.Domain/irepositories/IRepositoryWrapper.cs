using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSynchro.RJP.Domain.irepositories
{
    public interface IRepositoryWrapper
    {
        ICustomerRepository Customer { get; }
        IAccountRepository Account { get; }
        void Save();
    }
}
