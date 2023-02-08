﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClassLibrary
{
    public sealed class CheckingAccount : Account
    {
        const double MIN_DEPOSIT = 250;
        const double MAX_WITHDRAW = 1000;
        public CheckingAccount():base()
        {
            Commission = 0.01f;
        }
        public CheckingAccount(int aAccountId, string aCustomerName
        , DateTime aDateOfBirth, string aPhone = null, string aAddress = null) :
    base(aAccountId, aCustomerName, aDateOfBirth, aPhone, aAddress)
        {
            Commission = 0.01f;
        }

        public override bool DepositMoney(double aAmount)
        {
            if (!IsDepositMoneyRequestValid(aAmount)) return false;
            double NewAmountAfterCommission = aAmount - aAmount * Commission;
            return base.DepositMoney(NewAmountAfterCommission);
        }
        public override bool WithdrawMoney(double aAmount)
        {
            if (!IsWithdrawMoneyRequestValid(aAmount)) return false;
            double NewAmountAfterCommission = aAmount + aAmount * Commission;
            return base.WithdrawMoney(NewAmountAfterCommission);
        }
        public override void DisplayAccountInfo()
        {
            Console.WriteLine("Checking Account Balance: {0}, Commission: {1}", CurrentBalance, Commission);
        }

        public override bool IsDepositMoneyRequestValid(double aMoneyAmount)
        {
            if(aMoneyAmount<MIN_DEPOSIT)
            {
                return false;   
            }
            return true;
        }
        public override bool IsWithdrawMoneyRequestValid(double aMoneyAmount)
        {
            if(aMoneyAmount>MAX_WITHDRAW)
            {
                return false;
            }
            return true;
        }
    }
    

}
