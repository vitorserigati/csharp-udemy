namespace ExFuncionarioLib;
using System.Globalization;
public class Funcionario
{
    public int _id { get; private set; }
    public string? _name { get; private set; }
    public double _salary { get; private set; }

    public Funcionario() { }
    public Funcionario(int id, string name, double salary)
    {
        _id = id;
        _name = name;
        _salary = salary;
    }
    public void IncreaseSalary(double percent)
    {
        if (percent > 0 && percent <= 100.0)
        {
            Console.WriteLine($"{_salary.ToString("F2", CultureInfo.InvariantCulture)} , {percent.ToString("F2", CultureInfo.InvariantCulture)}");
            _salary += _salary * (percent/100.0);
        }
    }

    public override string ToString()
    {
        return _id + ", " + _name + ", " + _salary.ToString("F2", CultureInfo.InvariantCulture);
    }

}
