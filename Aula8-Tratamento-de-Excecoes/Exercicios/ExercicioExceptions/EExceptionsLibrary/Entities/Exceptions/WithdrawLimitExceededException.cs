namespace EExceptionsLibrary.Entities.Exceptions;

public class WithdrawLimitExceededException : ApplicationException
{
    public WithdrawLimitExceededException(string message) : base(message){}
}
