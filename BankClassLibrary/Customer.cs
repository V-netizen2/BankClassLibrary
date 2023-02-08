using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClassLibrary
{
    public  class Customer
    {
        public string _CustomerName;
        DateTime _DateOfBirth;
        public string _PhoneNumber;
        public string _Address;

        public string CustomerName
        {
            get
            {
                return _CustomerName;
            }
            set
            {
                _CustomerName = value;
            }
        }
        public DateTime DateOfBirth
        {
            get
            {
                return _DateOfBirth;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return _PhoneNumber;
            }
        }
        public string Address
        {
            get
            {
                return _Address;
            }
        }

        public Customer(string aCustomerName,DateTime aDateOfBirth,string aPhoneNumber,string aAddress)
        {
            _CustomerName = aCustomerName;
            _DateOfBirth = aDateOfBirth;
            _PhoneNumber = aPhoneNumber;
            _Address = aAddress;

        }
        public Customer(Customer accountCustomer) 
        {
            _CustomerName = accountCustomer._CustomerName;
            _DateOfBirth = accountCustomer._DateOfBirth;
            _PhoneNumber = accountCustomer._PhoneNumber;
            _Address = accountCustomer._Address;
        }

        //void UpdatePhone(string aNewPhone)
        //{

        //}
        //void UpdateAddress(string aNewAddress)
        //{

        //}

    }
}
