using BSynchro.RJP.DomainShared.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSynchro.RJP.Domain.models
{
    public class Account
    {
        public int Id { get; private set; }
        public double Balance { get; private set; }
        public DateTime CreationDate { get; private set; }
        public int CustomerId { get; private set; }

        public Customer Customer { get; private set; }

        public ICollection<Transaction> Transactions { get; private set; }


        private Account(double balance, DateTime creationDate, int customerId)
        {
            Balance = balance;
            CreationDate = creationDate;
            CustomerId = customerId;
            Transactions = new List<Transaction>();
        }


        public static Account Create(double balance, DateTime creationDate, int customerId)
        {
            return new Account(balance, creationDate, customerId);
        }

        public void AddTransaction(TransactionType transactionType, double amount, DateTime transactionDate)
        {
            Transactions.Add(Transaction.Create(transactionType, amount, transactionDate, Id));
        }

    }
}
