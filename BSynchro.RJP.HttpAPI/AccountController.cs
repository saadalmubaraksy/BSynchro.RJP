using BSynchro.RJP.ApplicationContract.DTOs;
using BSynchro.RJP.ApplicationContract.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSynchro.RJP.HttpAPI
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost(Name = "CreateAccount")]
        public void CreateAccount(CreateAccountRequest request)
        {
             _accountService.CreateAccount(request);
        }
    }
}
