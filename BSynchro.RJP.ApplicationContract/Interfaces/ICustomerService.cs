using BSynchro.RJP.ApplicationContract.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSynchro.RJP.ApplicationContract.Interfaces
{
    public interface ICustomerService
    {
        CustomerDto GetCustomerById(int customerId);
        List<CustomerDto> GetAllCustomer();
    }
}
