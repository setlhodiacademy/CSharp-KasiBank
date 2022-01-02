using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasiATM
{
    public class Account
    {
        public double DailyWithdrawalLimit { get; set; } = 600;
        private double Balance { get; }

        public Account(double openingBalance)
        {
            Balance = openingBalance;
        }

        public double Deposit(double amount)
        {
            return Balance + amount;            
        }

        public double ViewBalance()
        {

            return Balance;
        }

        public double Withdraw(double amount)
        {
            if (amount > Balance)
                throw new Exception($"You have insufficient amount. Available balance: R{Balance}");

            if(amount > DailyWithdrawalLimit)
                throw new Exception($"You've reached your daily withdrawal limit. Currently set limit: R{DailyWithdrawalLimit}");

            return  Balance - amount;
          
        }
    }
}
