namespace ExercicioMA.Entities;


public class LegalPerson : Person
{
    public int EmployeeNumber { get; private set; }
    public LegalPerson(string name, double annualIncome, int employeeNumber) : base(name, annualIncome)
    {
        if(employeeNumber < 0) throw new ArgumentOutOfRangeException("Employee Number cannot be less than 0", nameof(employeeNumber));
        EmployeeNumber = employeeNumber;
    }

    public override double CalculateTax()
    {
        double tax = 0;
        tax = (EmployeeNumber > 10) ? AnnualIncome * 0.14 : AnnualIncome * 0.16;

        return Math.Round(tax, 2);
    }

}
