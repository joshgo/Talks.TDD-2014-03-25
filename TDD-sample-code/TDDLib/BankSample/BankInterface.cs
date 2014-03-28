using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDLib.BankSample
{
    public interface IBankManager
    {
        void CreateAccount(string username, string password, string pin);
        IBankSession SignIn(string username, string password);
        void SignOut(string username, string password);
    }

    public interface IBankSession
    {
        void ChangePin(string newPin);
        void ChangePassword(string newPassword);

        void Deposit(double value);
        void Withdraw(double value);

        double GetBalance();
        List<TransactionModel> GetHistory(DateTime startDate, DateTime endDate);
    }

    public class TransactionModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public bool IsDeposit { get; set; }
        public double Amount { get; set; }
    }

    public class AccountModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Pin { get; set; }
        public List<TransactionModel> Transactions { get; set; }

        public double Balance
        {
            get
            {
                return Transactions.Sum(x => x.IsDeposit ? x.Amount : x.Amount * -1);
            }
        }
    }

    public class BankException : Exception
    {
        public BankException(string message) : base(message) { }
        public BankException(string message, Exception inner) : base(message, inner) { }
    }

    public interface IBankRepo
    {
        AccountModel GetAccount(int accountId);
        void AddAccount(AccountModel model);
        void DeleteAccount(int accountId);

        List<TransactionModel> GetTransactions(int account);
        void AddTransaction(int accountId, TransactionModel transaction);
        void DeleteTransaction(int accountId, TransactionModel transaction);
    }

}
