using System.Globalization;
namespace ExercicioProHP.Entities
{
    public class Product
    {
        public string Name { get; protected set; }
        public double Price { get; protected set; }

        public Product(string name, double price)
        {
            if(string.IsNullOrEmpty(name)){ throw new ArgumentException(nameof(name));}
            if(price <= 0) { throw new ArgumentException(nameof(price));}
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            StringWriter sw = new StringWriter();
            sw.Write(Name);
            sw.Write(" $ ");
            sw.Write(Price.ToString("F2", CultureInfo.InvariantCulture));
            return sw.ToString();
        }
    }
}
