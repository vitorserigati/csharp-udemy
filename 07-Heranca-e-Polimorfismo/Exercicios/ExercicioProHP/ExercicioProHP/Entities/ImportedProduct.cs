using System.Globalization;
namespace ExercicioProHP.Entities
{
    public sealed class ImportedProduct : Product
    {
        public double CustomsFee { get; private set; }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            if (customsFee <= 0.0) throw new ArgumentOutOfRangeException("CustomsFee must be higher than 0", nameof(customsFee));
            CustomsFee = customsFee;
        }
        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public sealed override string PriceTag()
        {
            StringWriter sw = new StringWriter();
            sw.Write(Name);
            sw.Write(" $ ");
            sw.Write(TotalPrice().ToString("F2", CultureInfo.InvariantCulture));
            sw.Write($" (Customs fee: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})");
            return sw.ToString();
        }
    }
}
