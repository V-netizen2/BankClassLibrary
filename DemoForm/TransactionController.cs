using BankClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Transactions;

namespace DemoForm
{
    public  class TransactionController
    {
        private Transaction model;
        public TransactionController(Transaction aModel)
        {
            model = aModel;
        }
        public void DisplayTransaction()
        {
            Console.WriteLine( model.TransactionTypeString+ "is done.");
            Console.WriteLine("Total Amount: " + model.MoneyAmount + "Date: " + model.DateString);
        }
    }
}
