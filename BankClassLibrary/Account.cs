using System.Net;

namespace BankClassLibrary
{
    public  class Account :AccountBase , IAccountValidatable
    {


        #region FIELDS AND PROPERTIES
        Customer _AccountCustomer;
        public static double ExchangeRate = 1.1d;
        private const string EMPTY_ADDRESS = "UNKNOWN";
        private const string EMPTY_PHONE = "#####";
        
        public override string CustomerName
        {
            get
            {
                return _AccountCustomer.CustomerName;
            }
            set
            {
                _AccountCustomer.CustomerName = value;
            }
            
        }
        public DateTime CustomerBirthDate
        {
            get
            {
                return _AccountCustomer.DateOfBirth;
            }
        }
        
        public string CustomerPhone
        {
            get
            {
                return _AccountCustomer.PhoneNumber;
            }
            //set
            //{
            //    if(string.IsNullOrEmpty(value))
            //    {
            //        _AccountCustomer._PhoneNumber = EMPTY_PHONE;
            //    }
            //    else { _AccountCustomer._PhoneNumber = value; }
                
            //}
        }
        public string CustomerAddress
        {
            get
            {
                return _AccountCustomer.Address;
                
            }
            //set
            //{
            //    if (string.IsNullOrEmpty(value))
            //    {
            //        _AccountCustomer._Address = EMPTY_ADDRESS;
            //    }
            //    else
            //    {
            //        _AccountCustomer._Address = value;

            //    }
            //}
        }
        
        DateTime DateOfBirth;
        string PhoneNumber;
        string Address;
        
        
    
    
        int _AccountNumber;
        public int AccountNumber
        {
            get
            {
                return _AccountNumber;
            }
        }
       
        double _CurrentBalance;
        public override double CurrentBalance
        {
            get
            {
                return _CurrentBalance;
            }
        }
        public double CurrentBalanceInForeignCurrency
        {
            get
            {
                return CurrentBalance * ExchangeRate;
            }
        }
        List<Transaction> _ListOfTransactions;
        public List<Transaction> ListOfTransactions
        {
            get
            {
                return _ListOfTransactions;
            }
        }
        public Transaction LastTransaction
        {
            get
            {
                if (_ListOfTransactions.Count >0)
                {
                    return _ListOfTransactions[_ListOfTransactions.Count-1];
                }
                else
                {
                    return null;
                }
            }
        }
        private double _Commission;
        public override double Commission
        {
            get
            {
                return _Commission;
            }
            set
            {
                _Commission = value;
            }
        }
        #endregion FIELDS AND PROPERTIES

        #region CONSTRUCTOR
        //Default Constructor
        public Account()
        {
            _AccountCustomer = new Customer("ADMIN", new DateTime(2000,1,1), null, null);
            _AccountNumber = Guid.NewGuid().GetHashCode();
            _ListOfTransactions = new List<Transaction>();
            _CurrentBalance = 0;
        }
        //Copy Constructor
        public Account(Account aAccountToCopy)
        {
            _AccountNumber = aAccountToCopy._AccountNumber;
            _CurrentBalance = aAccountToCopy._CurrentBalance;
            _ListOfTransactions = new List<Transaction>();
            for(int i=0;i<aAccountToCopy._ListOfTransactions.Count;i++)
            {
                _ListOfTransactions.Add(aAccountToCopy._ListOfTransactions[i]);
            }
            //Copy Customer 
            _AccountCustomer = new Customer(aAccountToCopy._AccountCustomer);

        }
        //Initialization
        public Account(string aCustomerName,DateTime aDateOfBirth,string aPhone=null,string aAddress=null)
        {
            _AccountCustomer = new Customer(aCustomerName,aDateOfBirth,aPhone,aAddress);
            _AccountNumber = Guid.NewGuid().GetHashCode();
            _ListOfTransactions = new List<Transaction>();
            _CurrentBalance = 0;
        }
         public Account(int aAccountId ,string aCustomerName,DateTime aDateOfBirth,string aPhone=null,string aAddress=null)
        {
            _AccountCustomer = new Customer(aCustomerName,aDateOfBirth,aPhone,aAddress);
            _AccountNumber = aAccountId;
            _ListOfTransactions = new List<Transaction>();
            _CurrentBalance = 0;
        }
        #endregion CONSTRUCTOR

        #region METHODS
        
        public override bool DepositMoney(double aAmount) 
        {
            bool isSuccess = true;

            _CurrentBalance += aAmount;
            Transaction myTransaction = new Transaction(aAmount, TransactionType.DEPOSIT);
            _ListOfTransactions.Add(myTransaction);

            return isSuccess;
        }
        public override bool WithdrawMoney(double aAmount)
        {
            bool isSuccess = true;
            if (_CurrentBalance < aAmount)
            {
                return false;
            }
            else
            {
                _CurrentBalance -= aAmount;
                Transaction myTransaction = new Transaction(aAmount, TransactionType.WITHDRAWAL);
                _ListOfTransactions.Add(myTransaction);
            }
             return isSuccess;
        }
        //to display the summary of account info to console
        public virtual void DisplayAccountInfo()
        {
            Console.WriteLine("Account Id :{0} Current Balance {1} Regular Account Type", _AccountNumber, _CurrentBalance);
        }
        protected sealed override void AddTransaction(Transaction newTransaction)
        {
            ListOfTransactions.Add(newTransaction);
            switch(newTransaction.TransactionTypeString)
            {
                case "Deposit":
                    _CurrentBalance += newTransaction.MoneyAmount;
                    break;
                case "Withdraw":
                    _CurrentBalance -= newTransaction.MoneyAmount;
                    break;
            }
        }

        public void DepositMoney(double transactionAmount, DateTime transactionDate, string transactionLocation)
        {
            Transaction newTransaction = new Transaction(transactionAmount,
                "Deposit", transactionDate, transactionLocation);
            this.AddTransaction(newTransaction);
        }

        public void WithdrawMoney(double transactionAmount, DateTime transactionDate, string transactionLocation)
        {
            Transaction newTransaction = new Transaction(transactionAmount,
                "Withdraw", transactionDate, transactionLocation);
            this.AddTransaction(newTransaction);
        }

        public  bool IsCustomerNameValid(string aCustomerName) 
        {
            if (!string.IsNullOrEmpty(aCustomerName) &&
                aCustomerName.Length > 2 &&
                aCustomerName.Length < 25)
            {
                return true;
            }
            return false;
        }
        public bool IsBirthDateValid(DateTime aBirthDate) 
        {
            if (DateTime.Compare(aBirthDate, new DateTime(DateTime.Now.Year - 18, 12, 31)) > 0)
            {
                return false;
            }
            return true;
        }
        public virtual bool IsDepositMoneyRequestValid(double aMoneyAmount) 
        {
            return true;
        }
       public virtual bool IsWithdrawMoneyRequestValid(double aMoneyAmount) 
        {
            return true;
        }

        #endregion METHODS

        #region NESTEDTYPES

        #endregion NESTEDTYPES

    }
}