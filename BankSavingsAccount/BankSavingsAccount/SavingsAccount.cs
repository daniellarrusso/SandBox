using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSavingsAccount
{
    public class SavingsAccount
    {
        private decimal _interestRate;

        private BankAccount _bankAccount;
        
        public SavingsAccount(decimal interest, BankAccount bankaccount)
        {
            this._bankAccount = bankaccount;
            this._interestRate = interest / 100;
        }

        public void Deposit(decimal depositAmount)
        {
            _bankAccount.Deposit(depositAmount);
        }

        public string OutputSavingsAccount()
        {
            return string.Format("{0} {1}", _bankAccount.OutputBankAccount(), _interestRate * 100);
        }

    }
}
