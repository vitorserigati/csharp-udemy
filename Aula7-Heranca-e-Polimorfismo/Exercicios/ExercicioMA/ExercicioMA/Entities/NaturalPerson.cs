namespace ExercicioMA.Entities;

public class NaturalPerson : Person
{
    public double HealthCare { get; private set; }

    public NaturalPerson(string name, double annualIncome, double healthCare) : base(name, annualIncome)
    {
        if(healthCare < 0) throw new ArgumentOutOfRangeException("HealthCare cannot be less than 0.", nameof(healthCare));
        HealthCare = healthCare;
    }

    public override double CalculateTax()
    {
        double tax = 0.0;
        tax = (AnnualIncome < 20000.0) ? AnnualIncome * 0.15 : AnnualIncome * 0.25;
    
        if(HealthCare > 0) tax -= HealthCare * 0.5;

        return tax;
    }
}
