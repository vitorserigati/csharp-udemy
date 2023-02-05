namespace EExceptionsLibrary.Entities;
using EExceptionsLibrary.Entities.Exceptions;
public class Account
{
    public int Number { get; private set; }
    public string Holder { get; }
    public decimal Balance { get; private set; }
    public decimal WithdrawLimit { get; private set; }

    public Account(int number, string holder, decimal balance, decimal withdrawLimit)
    {
        if(Decimal.IsNegative(balance) || Decimal.IsNegative(withdrawLimit)) 
            throw new ArgumentOutOfRangeException("Either balance or WithdrawLimit cannot be negative");
        Number = number;
        Holder = holder;
        Balance = balance;
        WithdrawLimit = withdrawLimit;
    }

    public void Deposit(decimal ammount)
    {
        Balance += ammount;
    }

    public void Withdraw(decimal ammount)
    {
        if(ammount > WithdrawLimit) throw new WithdrawLimitExceededException("The ammount exceeds withdraw limit");
        if (ammount > Balance) throw new OutOfBalanceException("Not enough balance");
        Balance -= ammount;
    }

}
