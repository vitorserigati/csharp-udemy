using System.Globalization;
namespace ExercicioP.Entities
{
    public class OrderItem
    {
        public int Quantity { get; private set; }
        public double Price { get; private set; }
        public Product Product { get; private set; }

        public OrderItem(int quantity, double price, string product)
        {
            Quantity = quantity;
            Price = price;
            Product = new Product(product, price);
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }
        public override string ToString()
                {
                    return $"{Product.Name}, ${Price.ToString("F2", CultureInfo.InvariantCulture)}, Quantity: {Quantity}, Subtotal: ${SubTotal().ToString("F2", CultureInfo.InvariantCulture)}";
                }
    }
}
