﻿using BankClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForm
{
    public partial class CreateAccountForm : Form
    {
        private string PhoneTextInput
        {
            get
            {
                if(PhoneMaskedTextBox.Enabled)
                {
                    return PhoneMaskedTextBox.Text;
                }
                else
                {
                    return null;
                }
            }
        }
        private string AddressTextInput
        {
            get
            {
                if(AddressRichTextBox.Enabled)
                {
                    return AddressRichTextBox.Text;
                }
                else
                {
                    return null;
                }
            }
        }
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Create button has been Clicked");
            string customerName = CustomerNameTextBox.Text;
            DateTime birthDate = BirthDatePicker.Value;
            //Validations
            if (!ValidateCustomerName(customerName))
            {
                MessageBox.Show("CustomerName is invalid");
                return;
            }
            if(!ValidateBirthDate(birthDate))
            {
                MessageBox.Show("BirthDate is Invalid");
                return;
            }


            string phone = PhoneTextInput;
            string address = AddressTextInput;

            //Account newAccount = new Account(customerName, birthDate, phone, address);
            CheckingAccount newCheckingAccount = new CheckingAccount(-1,customerName, birthDate, phone, address);
            SavingsAccount newSavingsAccount = new SavingsAccount(-1, customerName, birthDate, phone, address);

            //newAccount.DepositMoney(1000);
            //newAccount.WithdrawMoney(500);

            //newAccount.DisplayAccountInfo();
            //newCheckingAccount.DisplayAccountInfo();
            //StorageUtilityFunctions.SaveAccount(newAccount);
            //Account lastAccount = StorageUtilityFunctions.GetLastAccount();


            DisplayAccountForm displayAccount1 = new DisplayAccountForm(newCheckingAccount);
            DisplayAccountForm displayAccount2 = new DisplayAccountForm(newSavingsAccount);
            displayAccount1.Text = "Checking Account";
            displayAccount2.Text = "Savings Account";


            this.Hide();
            displayAccount1.Show();
            displayAccount2.Show();
           // this.Show();
            //MessageBox.Show("Account of Customer: " + customerName + " has been created");
        }

        private void PhoneCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PhoneMaskedTextBox.Enabled = PhoneCheckBox.Checked;
        }

        private void AddressCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            AddressRichTextBox.Enabled = AddressCheckBox.Checked;
        }

        private void CreateAccountForm_Load(object sender, EventArgs e)
        {

        }
        private bool ValidateCustomerName(string aTextToValidate)
        {
            if(!string.IsNullOrEmpty(aTextToValidate)&& 
                aTextToValidate.Length>2&&
                aTextToValidate.Length<25) 
            {
                return true;
            }
            return false;
        }
        private bool ValidateBirthDate(DateTime aDateToValidate) 
        {
            if(DateTime.Compare(aDateToValidate, new DateTime(DateTime.Now.Year - 18, 12, 31)) > 0)
            {
                return false;
            }
            return true;
        }
    }
}
