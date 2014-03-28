using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDLib.BankSample
{
    public class GoBankAuth : IBankManager
    {
        public void CreateAccount(string username, string password, string pin)
        {
            throw new NotImplementedException();
        }

        public IBankSession SignIn(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void SignOut(string username, string password)
        {
            throw new NotImplementedException();
        }
    }

    public class GoBankSession : IBankSession
    {
        public void ChangePin(string newPin)
        {
            throw new NotImplementedException();
        }

        public void ChangePassword(string newPassword)
        {
            throw new NotImplementedException();
        }

        public void Deposit(double value)
        {
            throw new NotImplementedException();
        }

        public void Withdraw(double value)
        {
            throw new NotImplementedException();
        }

        public double GetBalance()
        {
            throw new NotImplementedException();
        }

        public List<TransactionModel> GetHistory(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }
    }
}
