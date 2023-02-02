using System.Globalization;
namespace ExercicioProHP.Entities
{
    public class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; private set; }

        public UsedProduct(string name, double price, string manufactureDate) : base(name, price)
        {
            if (string.IsNullOrEmpty(manufactureDate) || string.IsNullOrWhiteSpace(manufactureDate))
            {
                throw new ArgumentException("Should be a date format: ", nameof(manufactureDate));
            }
            ManufactureDate = DateTime.Parse(manufactureDate);
        }

        public sealed override string PriceTag()
        {
            StringWriter sw = new StringWriter();
            sw.Write(Name);
            sw.Write(" (used) $ ");
            sw.Write(Price.ToString("F2", CultureInfo.InvariantCulture));
            sw.Write($" (Manufacture date: {ManufactureDate.ToShortDateString()})");
            return sw.ToString();
        }
    }
}
