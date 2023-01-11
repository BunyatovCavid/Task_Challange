using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Challenge
{
    internal class CheckingAcct : IAccount
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Balance { get; set; }
        public string AccountOwner { get; set; }

        public CheckingAcct(string name, string surname, decimal Balance)
        {
            Name = name;
            Surname = surname;
            this.Balance = Balance;
            AccountOwner = Name + " " + Surname; 
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (Balance > 0 && Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Balance -= (amount + 35);
            }
        }
    }

    class SavingsAcct : IAccount
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Balance { get; set; }
        public decimal Percent { get; set; }
        public int Counter { get; set; }
        public string AccountOwner { get; set; }


        public SavingsAcct(string name, string surname, decimal percent, decimal balance)
        {
            Name = name;
            Surname = surname;
            Balance = balance;
            Percent = percent;
            AccountOwner = Name + " " + Surname;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Counter++;
            if (Balance > 0 && Balance>amount)
            {
                if (Counter <= 3)
                    Balance -= amount;
                else
                    Balance -= (amount + 2);
            }
            else
            {
                Console.WriteLine("You cannot withdraw because your balance is insufficient");
            }
        }

        public void ApplyInterest()
        {
            Balance +=(Balance * Percent);
        }
    }
}
