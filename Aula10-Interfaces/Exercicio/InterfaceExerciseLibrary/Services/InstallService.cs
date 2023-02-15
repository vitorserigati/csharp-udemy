namespace InterfaceExerciseLibrary.Services;
using InterfaceExerciseLibrary.Entities;

public class InstallService
{
    public int InstallmentAmmount { get; private set; }
    private IPaymentService _paymentService;

    public InstallService(int installmentAmmount, IPaymentService paymentService)
    {
        InstallmentAmmount = installmentAmmount;
        _paymentService = paymentService;
    }

    public void ProcessInstall(Contract contract)
    {
        DateTime contractDate = contract.Date;
        decimal value = contract.TotalValue / InstallmentAmmount;

        for (int i = 1; i <= InstallmentAmmount; i++)
        {
            decimal installmentValue = _paymentService.CalculateInstallment(i, value);
            DateTime months = contractDate.AddMonths(i);
            Installment newInstallment = new Installment(months, installmentValue);
            contract.AddInstallment(newInstallment);
        }
    }
}
