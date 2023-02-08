// See https://aka.ms/new-console-template for more information
using BankClassLibrary;
using System.Runtime.CompilerServices;
using System.Security.Principal;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loopCondition = true;
            //Create an account
            Account myAccount = CreateAccount();
            


            while (loopCondition)
            {
                //Deposit Money
                DepositMoney(myAccount,1000);
                //Display Tranaction
                myAccount.LastTransaction.DisplayTransaction();
                //Withdraw Money
                WithdrawMoney(myAccount,500);
                myAccount.LastTransaction.DisplayTransaction();
                //Display Balance
                DisplayMoney(myAccount);
                //Console.ReadKey();
                UtilityMethods.PressAnyKeyToContinue();

            }
           
            

        }
        private static void DepositMoney(Account aAccount,double aMoney)
        {
            aAccount.DepositMoney(aMoney);
        }
        private static void WithdrawMoney(Account aAccount, double aMoney)
        {
            aAccount.WithdrawMoney(aMoney);
        }
        private static void DisplayMoney(Account aAccount)
        {
            aAccount.DisplayBalance();

        }
        private static Account CreateAccount()
        {
            
            string customerName = UtilityMethods.ReadTextInput("enter your name:");

            //Console.WriteLine("enter your BirthDay:day ,Month,Year");
            int day = UtilityMethods.ReadNumericInput("enter your BirthDay:day");
            int month = UtilityMethods.ReadNumericInput("enter your BirthDay:month");
            int year = UtilityMethods.ReadNumericInput("enter your BirthDay:year");


            string phone = UtilityMethods.ReadTextInput("enter phone");
            string address = "";
            UtilityMethods.ReadTextInput("enter address", ref address);

            Account newAccount = new Account(customerName, new DateTime(year, month, day), phone, address);
            return newAccount;

        }
    }
}

