using AutoMapper;
using BSynchro.RJP.ApplicationContract.DTOs;
using BSynchro.RJP.ApplicationContract.Interfaces;
using BSynchro.RJP.Domain.irepositories;
using BSynchro.RJP.Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSynchro.RJP.Application
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public CustomerService(IRepositoryWrapper repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public CustomerDto GetCustomerById(int customerId)
        {
            return _mapper.Map<CustomerDto>(_repository.Customer.FindByCondition(x => x.Id == customerId).FirstOrDefault());
        }

        public List<CustomerDto> GetAllCustomer()
        {
            return _mapper.Map<List<CustomerDto>>(_repository.Customer.FindAll().ToList());
        }
    }
}
