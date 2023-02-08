using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClassLibrary
{
    public class Transaction
    {
        #region FIELDS AND PROPERTIES
        double _MoneyAmount;
        DateTime _TransactionDate;
        string _Location;
        //Tracsation type
        TransactionType _TypeOfTransaction;

        public double MoneyAmount
        {
            get
            {
                return _MoneyAmount;
            }
            set
            {
                _MoneyAmount = value;
            }
        }
        public string Summary
        {
            get
            {
                return TransactionTypeString + " "
                    + MoneyAmount + " " + DateString;
            }
        }
        public string TransactionTypeString
        {
            get
            {
                return (_TypeOfTransaction == TransactionType.DEPOSIT ? "Deposit" : "Withdraw");
            }
        }
        public string LocationString
        {
            get
            {
                return _Location;
            }
        }
        public string DateString
        {
            get
            {
                return _TransactionDate.ToString("yyyy/MM/dd hh:mm:dd");
            }
        }

        public DateTime TransactionDate
        {
            get
            {
                return _TransactionDate;

            }
        }
        #endregion

        #region METHODS
        
        #endregion
        #region CONSTRUCTOR
        private Transaction()
        {

        }
        public Transaction(double aAmountOfTransaction, TransactionType aTransactionType)
        {
            _MoneyAmount = aAmountOfTransaction;
            _TypeOfTransaction = aTransactionType;
            _TransactionDate = DateTime.Now;
            _Location = "EARTH";
        }
        public Transaction(double aAmountOfTransaction
            ,string aTransactionTypeString
            ,DateTime aTransactionDate
            ,string aTransactionLocation)
        {
            _MoneyAmount = aAmountOfTransaction;
            _TransactionDate= aTransactionDate;
            _Location= aTransactionLocation;
            switch (aTransactionTypeString)
            {
                case "Deposit":
                    _TypeOfTransaction= TransactionType.DEPOSIT;
                    break;
                case "Withdraw":
                    _TypeOfTransaction = TransactionType.WITHDRAWAL;
                    break;

            }
        }
        //Copy Constructor
        public Transaction(Transaction aTransactionToCopy)
        {
            _MoneyAmount = aTransactionToCopy._MoneyAmount;
            _TypeOfTransaction = aTransactionToCopy._TypeOfTransaction;
            _TransactionDate = aTransactionToCopy._TransactionDate;
            _Location = aTransactionToCopy._Location;
        }
        #endregion
    }

    public enum TransactionType
    {
        DEPOSIT,
        WITHDRAWAL
    }
}
