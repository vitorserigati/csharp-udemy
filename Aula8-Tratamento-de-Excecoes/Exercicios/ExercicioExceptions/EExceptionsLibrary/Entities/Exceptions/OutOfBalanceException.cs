namespace EExceptionsLibrary.Entities.Exceptions;

public class OutOfBalanceException : ApplicationException
{
    public OutOfBalanceException(string message) : base(message) { }
}
