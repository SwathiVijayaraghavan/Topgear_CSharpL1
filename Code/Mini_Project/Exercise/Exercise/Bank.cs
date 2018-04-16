using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Bank
    {
        private Bank()
        {

        }

        private static Hashtable _bankAccounts = new Hashtable();
        private static Audit _audit = new Audit();

        public static Account CreateAccount(BankAccountType type)
        {
            long value = 0;
            do
            {
                var r = new Random();
                value = (long)(r.NextDouble() * long.MaxValue);
                var v = _bankAccounts[value];
                if (v == null)
                    break;
            } while (true);

            var b = new Account(value, 0)
            {
                AccountType = type
            };
            b.Auditing += _audit.CreateAuditRecord;
            _bankAccounts.Add(value, b);
            return b;
        }
    }

    public enum BankAccountType
    {
        Checking,
        Deposit
    }

    public delegate void TransactionHappened(BankTransaction a);

    public class Account
    {
        private long _accountNumber;
        private decimal _accountBalance;
        public BankAccountType AccountType { get; set; }
        private List<BankTransaction> _transactions;

        public event TransactionHappened Auditing;

        public long GetAccountNumber()
        {
            return _accountNumber;
        }

        public decimal GetAccountBalance()
        {
            return _accountBalance;
        }

        internal Account(long accountNumber, decimal accountBalance)
        {
            _accountNumber = accountNumber;
            _accountBalance = accountBalance;
            _transactions = new List<BankTransaction>();
        }

        public void Withdraw(decimal amount)
        {
            if (_accountBalance - amount > 0)
            {
                _accountBalance -= amount;
                var t = new BankTransaction(-amount);
                _transactions.Add(t);
                Auditing(t);
            }
            else
            {
                throw new Exception("Insufficied account balance");
            }
        }

        public void Deposit(decimal amount)
        {
            _accountBalance += amount;
            var t = new BankTransaction(amount);
            _transactions.Add(t);
            Auditing(t);
        }
    }

    public class BankTransaction
    {

        public DateTime TransactionTime { get; }

        public decimal TransactionAmount { get; }

        public BankTransaction(decimal transactionAmount)
        {
            TransactionTime = DateTime.Now;
            TransactionAmount = transactionAmount;
        }


    }


    class Audit
    {
        public void CreateAuditRecord(BankTransaction transaction)
        {
            var s = string.Format("Transaction Time: {0}\r\nTransaction Type: {1}\r\nTransaction Amount: {2}\r\n\r\n",
                transaction.TransactionTime, transaction.TransactionAmount < 0 ? "Withdrawal" : "Deposit", transaction.TransactionAmount
            );
            //File.AppendAllText("Log.txt",s);
            Console.WriteLine(s);
        }
    }

}
