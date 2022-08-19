using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSynchro.RJP.ApplicationContract.DTOs
{
    public class AccountDto
    {
        public int Id { get; set; }
        public double Balance { get; set; }
        public DateTime CreationDate { get; set; }
        public AccountCustomerDto Customer { get; set; }
        public ICollection<TransactionDto> Transactions { get; set; }
    }
}
