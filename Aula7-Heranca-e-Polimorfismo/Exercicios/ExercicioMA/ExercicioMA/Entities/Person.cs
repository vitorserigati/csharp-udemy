namespace ExercicioMA.Entities;

public abstract class Person
{
    public string Name { get; protected set; }
    public double AnnualIncome {get; protected set;}

    public Person(string name, double annualIncome)
    {
        if(string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException("name cannot be null or white spaces", nameof(name));
        if(annualIncome < 0) throw new ArgumentOutOfRangeException("Annual Income must be higher than 0", nameof(annualIncome));
        Name = name;
        AnnualIncome = annualIncome;
    }

    public abstract double CalculateTax();
}
