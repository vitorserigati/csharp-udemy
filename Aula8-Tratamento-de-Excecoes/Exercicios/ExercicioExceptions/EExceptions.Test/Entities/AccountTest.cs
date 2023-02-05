namespace EExceptions.Test.Entities;
using EExceptionsLibrary.Entities;
using EExceptionsLibrary.Entities.Exceptions;

public class AccountTest
{
    Account sut;
    public AccountTest()
    {
        sut = new(1, "John Doe", 200.00m, 150.00m);
    }

    [Fact]
    public void ShouldBePossibleToDepositMoneyToAccount()
    {
        decimal expected = 400.00m;
        sut.Deposit(200.00m);
        decimal actual = sut.Balance;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ShouldBePossibleToWithdrawMoneyFromAccount()
    {
        decimal expected = 50.0m;
        sut.Withdraw(150.00m);
        decimal actual = sut.Balance;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ShouldThrowNewOutOfBalanceException()
    {
        sut = new(1, "John Doe", 299.00m, 500.00m);
        Action act = () => sut.Withdraw(300.00m);

        Assert.Throws<OutOfBalanceException>(act);
    }
    [Fact]
    public void ShouldThrowNewWithdrawLimitExceededException()
    {
        Action act = () => sut.Withdraw(151.00m);

        Assert.Throws<WithdrawLimitExceededException>(act);
    }
    [Theory]
    [InlineData(1, "John Doe", -5.00, 0.01)]
    [InlineData(1, "John Doe", 0.00, -1.00)]
    public void ShouldNotBeAbbleToCreateAccountWithNegativeBalanceOrWithdrawLimit(int id, string name, decimal balance, decimal withdrawLimit)
    {
        Action act = () => new Account(id, name, balance, withdrawLimit);

        Assert.Throws<ArgumentOutOfRangeException>(act);
    }
}
