namespace ExercicioP.Entities
{
    public class Product
    {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public Product(string name, double price)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException("Product name cannot be blank", nameof(name));
            if (price <= 0) throw new ArgumentOutOfRangeException(nameof(price));

            Name = name;
            Price = price;
        }
    }
}
