using BSynchro.RJP.ApplicationContract.DTOs;
using BSynchro.RJP.ApplicationContract.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BSynchro.RJP.HttpAPI
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        //[HttpGet(Name = "GetCustomerById/{id}")]
        //public CustomerDto GetCustomerById(int customerId)
        //{
        //    return _customerService.GetCustomerById(customerId);
        //}

        [HttpGet(Name = "GetAllCustomers")]
        public List<CustomerDto> GetAllCustomers()
        {
            return _customerService.GetAllCustomer();
        }

        [HttpPost(Name = "Create Customer")]
        public void CreateCustomer(string fName,string lName)
        {
            _customerService.CreateCustomer(fName,lName);
        }
    }
}
