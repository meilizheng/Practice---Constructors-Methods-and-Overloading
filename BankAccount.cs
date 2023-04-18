using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Constructors__Methods__and_Overloading
{
    public class BankAccount
    {
        //creat field
        string _AccountNumber;
        string _CustomerName;
        double _Balance;

        public BankAccount(string accountNumber, string customerName, double balance) //creat constructor with all arguments;
        {
            _AccountNumber = accountNumber;
            _CustomerName = customerName;
            _Balance = balance;
        }

        public string AccountNumber { get => _AccountNumber; } //account number read only
        public string CustomerName { get => _CustomerName; set => _CustomerName = value; } 
        public double Balance { get => _Balance; } //balance read only

        public void Deposit( double amount) //Method for deposit:  
        {
            if (amount > 0)//if user passes a positive number add it to balance
            {
                _Balance += amount;
            }           
        }

        public void WithDraw(double amount) //creat a withdraw method
        {
            if(amount > 0 && amount <= _Balance)//if user passes a positive number subtract it from the balance
            {
                _Balance -= amount;
            }            
        }

        public override string ToString() //display the information
        {
            return $"{_AccountNumber}  {_CustomerName} - Curren Blance: {_Balance.ToString("c")}";
        }
    }
}
