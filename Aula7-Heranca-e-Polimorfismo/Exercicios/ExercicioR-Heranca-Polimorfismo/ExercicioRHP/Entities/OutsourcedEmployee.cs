namespace ExercicioRHP.Entities
{
    sealed class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; private set; }

        public OutsourcedEmployee() { }

        public OutsourcedEmployee(string name, int hours, double value, double additionalCharge) : base(name, hours, value)
        {
            AdditionalCharge = additionalCharge;
        }

        public sealed override double Payment()
        {
            return base.Payment() + (AdditionalCharge * 1.1);
        }
    }
}
