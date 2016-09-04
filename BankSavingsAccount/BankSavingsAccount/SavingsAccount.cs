using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSavingsAccount
{
    public class SavingsAccount : BankAccount
    {
        private decimal _interestRate;

        public SavingsAccount(decimal interest) : this(interest, 0) { }

        public SavingsAccount(decimal interest, decimal initalBalance) : base(initalBalance)
        {
            _interestRate = interest / 100;
        }

        public void AccumalateInterest()
        {
            _balance = _balance + (_balance * _interestRate);
        }

        public string OutputSavingsAccount()
        {
            return string.Format("{0} {1}", OutputBankAccount(), _interestRate * 100);
        }

        
        new public void Withdraw(decimal withdrawalAmount)
        {
            base.Withdraw(1.50M);

            base.Withdraw(withdrawalAmount);
        }

    }
}
