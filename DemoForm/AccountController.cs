using BankClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForm
{
    public  class AccountController
    {
        private Account model;
        public AccountController(Account aAccount)
        {
            model = aAccount;
        }
        public void DisplayBalance()
        {
            Console.WriteLine("Current Balance Is: " + model.CurrentBalance);
        }
    }
}
