using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Challenge
{
    internal interface IAccount
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Balance { get; set; }
        public string AccountOwner { get; set; } 

        public void Deposit(decimal amount);
        public void Withdraw(decimal amount);

    }
}
