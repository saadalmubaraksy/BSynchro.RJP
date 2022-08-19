using AutoMapper;
using BSynchro.RJP.ApplicationContract.DTOs;
using BSynchro.RJP.Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSynchro.RJP.ApplicationContract.profiles
{
    public class CustomerProfile:Profile
    {
        public CustomerProfile() 
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>();
            CreateMap<Account, CustomerAccountDto>();

        }
    }
}
