﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClassLibrary
{
    public abstract class AccountBase
    {
        public abstract string CustomerName { get; set; }
        public abstract double CurrentBalance { get;  }
        public abstract double Commission { get; set; }
        public abstract bool DepositMoney(double aMoneyAmount);
        public abstract bool WithdrawMoney(double aMoneyAmount);

        protected abstract void AddTransaction(Transaction aNewTransaction);

    }
}
