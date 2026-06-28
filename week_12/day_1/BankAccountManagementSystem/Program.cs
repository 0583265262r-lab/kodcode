using System;
using System.Security.Principal;
using System.Xml;
namespace BankAccunt;

enum AccountType {Savings, Checking, Business};
class ManagementSystem
{
    private int _accountNumber {get;}
    private string _ownerName { get; set;}
    private double _balance{ get; set;}
    private string _accountType { get; set; }
    private bool _isActive { get; set; }
    private List<string> _transactionHistory;
    public int AccountNumber {get => _accountNumber; }
    public string OwnerName
    {
        get => _ownerName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                _ownerName = "Unknown";
            }
            else
            {
                _ownerName = value;
            }
        }
    }
    public double Balance
    {
        get => _balance;
        set
        {
            if (value<0)
            {
                _balance = 0;
            }
            else
            {
                _balance = value;
            }
        }
        

    }
    public string AccountType
    {
        get => _accountType;
        set
        {
            if (Enum.TryParse<AccountType>(value,true,out _))
            {
                _accountType = value;
            }
            else
            {
                _accountType = "Checking";
            }
        }
    }


    public ManagementSystem(int accountNumber,string ownerName,double balance, string accountType)
    {
        _accountNumber = accountNumber;
        OwnerName = ownerName;
        Balance = balance;
        AccountType = accountType;
        _isActive = true;
        _transactionHistory = new List<string>() ;
    }
    public ManagementSystem(int accountNumber): this(accountNumber,"david", 0.0, "Checking") { }
    public void Activate() => _isActive = true;
    public void Deactivate() => _isActive = false;
    public override string ToString()
        => $"Account Number: {_accountNumber} | Owner Name: {_ownerName} | Balance : {_balance} | account type : {_accountType} | Is Active: {_isActive}";
    public void Deposit(double amount)
    {
        if (amount<0 )
        {
            Console.WriteLine("Error: amount must be greater than 0");
        }
        else
        {
            _balance += amount;
            _transactionHistory.Add($"Depositing {amount}$ to account {_accountNumber}");
        }
    }
    public void PrintTransactionHistory()
    {
        for (int i = 0; i < _transactionHistory.Count(); i++)
        {
            Console.WriteLine(_transactionHistory[i]);
        }
    }
    public bool Withdraw(double amount)
    {
        if (amount <0 | amount >= _balance)
        {
            Console.WriteLine($"Error : Insufficient funds. Cannot withdraw {amount}$ from account {_accountNumber}");
            return false;
        }
        else
        {
            _balance -= amount;
            _transactionHistory.Add($"Withdrawing {amount}$ from account {_accountNumber}");
        }
        return true;
    }




}
class Progrem
{
    static void Main()
    {
        ManagementSystem m = new ManagementSystem(3);
        //m.Deactivate();
        Console.WriteLine(m);
        Console.ReadKey();
        m.Deposit(345);
        m.Deposit(56525);
        m.PrintTransactionHistory();
        Console.WriteLine(m);
        m.Withdraw(766);
        m.PrintTransactionHistory();
        Console.WriteLine(m);
        m.Withdraw(6909970);
        m.PrintTransactionHistory();



    }
}