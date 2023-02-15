namespace InterfaceExerciseLibrary.Services;

public interface IPaymentService
{
    decimal CalculateInstallment(int installmentsAmount, decimal contractValue);
}
