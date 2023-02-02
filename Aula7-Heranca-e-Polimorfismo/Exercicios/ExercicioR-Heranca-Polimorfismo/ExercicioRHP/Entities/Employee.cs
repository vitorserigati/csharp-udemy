using System.Globalization;
namespace ExercicioRHP.Entities
{
    class Employee
    {
        public string Name { get; protected set; }
        public int Hours { get; protected set; }
        public double ValuePerHour { get; protected set; }

        public Employee() { }
        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return ValuePerHour * Hours;
        }
        public override string ToString()
        {
            StringWriter sw = new StringWriter();
            sw.Write("Nome: ");
            sw.Write(Name);
            sw.Write(" Payment: R$");
            sw.Write(Payment().ToString("F2", CultureInfo.InvariantCulture));
            return sw.ToString();
        }
    }
}
