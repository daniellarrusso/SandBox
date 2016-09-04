using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSavingsAccount
{
    public class BankAccount
    {
        protected decimal _balance;
        private static int _nextAccountNumber = 1000;
        private int _accountNumber;

        public BankAccount() : this(0) { }

        public BankAccount(decimal balance)
        {
            _accountNumber = ++_nextAccountNumber;
            _balance = balance;
        }

        public void Withdraw(decimal withdrawal)
        {
            if (_balance <= withdrawal)
            {
                _balance = 0;
            }
            _balance -= withdrawal;
        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                _balance += amount;
            }
        }

        public string OutputBankAccount()
        {
            return string.Format("{0} {1:C}", _accountNumber, _balance);
        }

    }
}
