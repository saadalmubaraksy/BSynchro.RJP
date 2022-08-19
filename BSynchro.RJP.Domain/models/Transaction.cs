using BSynchro.RJP.DomainShared.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSynchro.RJP.Domain.models
{
    public class Transaction
    {
        public int Id { get; private set; }
        public TransactionType TransactionType { get; private set; }
        public double Amount { get; set; }
        public DateTime TransactionDate { get; private set; }
        public int AccountId { get; private set; }
        public Account Account { get; private set; }


        private Transaction(TransactionType transactionType, double amount, DateTime transactionDate, int accountId)
        {
            TransactionType = transactionType;
            Amount = amount;
            TransactionDate = transactionDate;
            AccountId = accountId;
        }


        public static Transaction Create(TransactionType transactionType, double amount, DateTime transactionDate, int accountId)
        {
            return new Transaction(transactionType, amount, transactionDate, accountId);
        }
    }
}



