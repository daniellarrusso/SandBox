using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSavingsAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount(2000M);
            ba.Deposit(1000M);
            ba.Withdraw(40);
            Console.WriteLine(ba.OutputBankAccount());


            SavingsAccount sa = new SavingsAccount(5.9M, sa);
            sa.Deposit(200);
            Console.WriteLine(sa.OutputSavingsAccount());
            
            Console.ReadLine();
        }
    }
}
