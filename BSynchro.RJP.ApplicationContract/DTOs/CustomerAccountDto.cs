using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSynchro.RJP.ApplicationContract.DTOs
{
    public class CustomerAccountDto
    {
        public int Id { get; set; }
        public double Balance { get; set; }
        public DateTime CreationDate { get; set; }
        public List<TransactionDto> Transactions { get; set; }
    }
}
