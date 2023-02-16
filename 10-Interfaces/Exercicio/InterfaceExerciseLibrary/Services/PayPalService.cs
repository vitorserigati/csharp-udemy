namespace InterfaceExerciseLibrary.Services;

public class PayPalService : IPaymentService
{
    private const decimal SimpleTax = 0.01M;
    private const decimal PaymentTax = 0.02M;


    public decimal CalculateInstallment(int installmentsAmount, decimal contractValue)
    {
        decimal totalValue = contractValue;
        totalValue += contractValue * SimpleTax * installmentsAmount;
        totalValue += totalValue * PaymentTax;
        return totalValue;

    }
}
