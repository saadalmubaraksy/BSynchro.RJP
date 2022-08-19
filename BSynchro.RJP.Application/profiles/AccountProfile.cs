using AutoMapper;
using BSynchro.RJP.ApplicationContract.DTOs;
using BSynchro.RJP.Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSynchro.RJP.Application.profiles
{
    public class AccountProfile : Profile
    {
        public AccountProfile(string profileName) : base(profileName)
        {
            CreateMap<Account, AccountDto>();
        }
    }
}
