using BankClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForm
{
    public static class StorageUtilityFunctions
    {
        const string MainStorageDir = @"C:\temp";
        const string CustStorageDir = @"C:\temp2";
        const string DateStringFormat = "yyyy:MM:dd HH:mm";
        static StorageUtilityFunctions()
        {
            if (!CheckMainDirectory())
            {
                Directory.CreateDirectory(MainStorageDir);
                Directory.CreateDirectory(CustStorageDir);
            }
        }
        static bool CheckMainDirectory()
        {
            if(Directory.Exists(MainStorageDir) && Directory.Exists(CustStorageDir))
            {
                return true;
            }
            return false;
        }
        public static Account GetLastAccount()
        {
            Account lastAccount = new Account();
            DirectoryInfo dirInfo = new DirectoryInfo(MainStorageDir);
            FileInfo[] fileInfoArray = dirInfo.GetFiles();

            if (fileInfoArray.Length == 0)
            {
                return null;
            }

            FileInfo lastFileInfo = fileInfoArray.OrderByDescending(f => f.LastWriteTime).First();
            string filePath = lastFileInfo.FullName;
            string fileName = Path.GetFileNameWithoutExtension(filePath);

            int accountId = Convert.ToInt32(fileName);
            string customerName;
            using(StreamReader sr = File.OpenText(fileName))
            {
                string headerLine = sr.ReadLine();
                string[] headerParts = headerLine.Split('_');
                customerName = headerParts[1];

                DateTime birthDate;
                string phoneNumber;
                string address;

                string nextLine;
                using (StreamReader srForCustomer = File.OpenText(CustStorageDir+ "\\" + customerName + ".dat"))
                {
                     nextLine = srForCustomer.ReadLine();
                    address = nextLine;

                    headerParts = nextLine.Split('_');

                    birthDate = DateTime.ParseExact(headerParts[1], DateStringFormat, null);

                    phoneNumber = headerParts[2];
                    nextLine = srForCustomer.ReadLine();
                    while(!string.IsNullOrEmpty( nextLine ) )
                    {
                        string addressLine = nextLine;
                        address += "\n" + addressLine;
                        nextLine = srForCustomer.ReadLine();
                    }
                }
                lastAccount = new Account(accountId,customerName,birthDate,phoneNumber,address);
                 nextLine = sr.ReadLine();

                while(!string.IsNullOrEmpty(nextLine))
                {
                    //transaction Line
                    string transactionLine = nextLine;
                    nextLine = sr.ReadLine() ;

                    string []transactionParts = transactionLine.Split('_');
                    string transactionType = transactionParts[0];
                    double transactionAmount = Convert.ToDouble(transactionParts[1]);
                    DateTime transactionDate = DateTime.ParseExact(transactionParts[2], DateStringFormat, null);
                    string transactionLocation = transactionParts[3];
                    switch (transactionType)
                    {
                        case "Deposit":
                            lastAccount.DepositMoney(transactionAmount, transactionDate, transactionLocation);
                            break;
                        case "Withdraw":
                            lastAccount.WithdrawMoney(transactionAmount, transactionDate, transactionLocation);
                            break;
                    }
                    

                    //Transaction newTransaction = new Transaction(transactionAmount,
                    //    transactionType, transactionDate, transactionLocation);
                    //lastAccount.AddTransaction(newTransaction);
                }
            }
            return lastAccount;

            //string[] accountFiles = Directory.GetFiles(MainStorageDir);
            //if (accountFiles.Length == 0)
            //{
            //    return null;
            //}
            //string lastAccountFile = accountFiles[accountFiles.Length - 1];
        }
        public static bool SaveAccount(Account aAccount) 
        {
            //FileName    AccountId.dat
            //HeaderLine  AccountId_CustomerName
            //DataLines   TransactionType_TransactionAmount_TransactionDate_Location
            using (StreamWriter sw = 
                File.CreateText(MainStorageDir + "\\" + aAccount.AccountNumber + " .dat"))
            {
                sw.WriteLine(aAccount.AccountNumber + "_"+aAccount.CustomerName);
                foreach(Transaction tr in aAccount.ListOfTransactions)
                {
                    string transactionLine = tr.TransactionTypeString + "_" +
                        tr.MoneyAmount + "_" +
                        tr.TransactionDate.ToString(DateStringFormat) + "_" +
                        tr.LocationString;
                    sw.WriteLine(transactionLine);
                }
            }
            //FileName    CustomerName.dat
            //HeaderLine  CustomerName_BirthDate_Phone
            //DataLines   AddressLine1\nAddressLine2\nAddressLine3 ...

            FileInfo fileInfoObject = new FileInfo(CustStorageDir + "\\" + aAccount.CustomerName + ".dat");

            using(StreamWriter sw = fileInfoObject.CreateText())
            {
                sw.WriteLine(aAccount.CustomerName+"_"+
                    aAccount.CustomerBirthDate.ToString(DateStringFormat)+"_"
                    +aAccount.CustomerPhone);
                string[] addressLines = aAccount.CustomerAddress.Split(new char[] { '\r', '\n' });
                foreach(string addressLine in addressLines)
                {
                    sw.WriteLine(addressLine);
                }
            }
            return false;
        }

    }
}
