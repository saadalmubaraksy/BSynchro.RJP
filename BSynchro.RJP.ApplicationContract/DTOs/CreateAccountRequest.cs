using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSynchro.RJP.ApplicationContract.DTOs
{
    public class CreateAccountRequest
    {
        [Required]
        public int CustomerId { get; set; }

        [Required]
        public double InitialCredit { get; set; }
    }
}
