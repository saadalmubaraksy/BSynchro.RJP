using AutoMapper;
using BSynchro.RJP.ApplicationContract.DTOs;
using BSynchro.RJP.ApplicationContract.Interfaces;
using BSynchro.RJP.Domain.irepositories;
using BSynchro.RJP.Domain.models;
using BSynchro.RJP.DomainShared.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSynchro.RJP.Application
{
    public class AccountService: IAccountService
    {
        private readonly ICustomerService _customerService;
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public AccountService(ICustomerService customerService, IMapper mapper, IRepositoryWrapper repository)
        {
            _customerService = customerService;
            _mapper = mapper;
            _repository = repository;
        }

        public void CreateAccount(CreateAccountRequest createAccountRequest)
        {
            Customer customer = _repository.Customer
                .FindByCondition(x=>x.Id == createAccountRequest.CustomerId).FirstOrDefault();

            if(customer == null)
            {
                throw new Exception("Customer not found");
            }

            var account = customer.AddAccount(createAccountRequest.InitialCredit,DateTime.UtcNow);

            if (createAccountRequest.InitialCredit > 0)
            {
                account.AddTransaction(TransactionType.INITIAL, createAccountRequest.InitialCredit, DateTime.UtcNow);
            }
            _repository.Customer.Update(customer);

            _repository.Save();
        }
    }
}
