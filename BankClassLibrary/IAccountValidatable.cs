using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClassLibrary
{
    internal interface IAccountValidatable
    {
        bool IsCustomerNameValid(string aCustomerName);
        bool IsBirthDateValid(DateTime aBirthDate);
        bool IsDepositMoneyRequestValid(double aMoneyAmount);
        bool IsWithdrawMoneyRequestValid(double aMoneyAmount);

    }
}
