using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSynchro.RJP.Domain.models
{
    public class Customer
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string LastName { get; private set; }

        public ICollection<Account> Accounts { get; private set; }


        private Customer(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
            Accounts = new List<Account>();
        }

        public static Customer Create(string name, string lastName)
        {
            return new Customer(name, lastName);
        }

        public void AddAccount(double balance, DateTime creationDate)
        {
            Accounts.Add(Account.Create(balance, creationDate, Id));
        }
    }
}
