using System;
namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var acc = Bank.CreateAccount(BankAccountType.Deposit);
            acc.Deposit(500);
            acc.Withdraw(200);
        }
    }
}


