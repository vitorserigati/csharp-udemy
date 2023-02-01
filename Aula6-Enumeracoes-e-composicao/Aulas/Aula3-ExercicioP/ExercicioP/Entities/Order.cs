using ExercicioP.Entities.Enum;
namespace ExercicioP.Entities
{
    class Order
    {
        public DateTime Moment { get; private set; }
        public OrderStatus Status { get; private set; }
        public List<OrderItem> Items { get; private set; } = new List<OrderItem>();
        public Client Client { get; private set; }

        public Order(OrderStatus status, Client client)
        {
            Moment = DateTime.Now;
            Client = client;
            Status = status;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double total = 0;
            foreach(OrderItem item in Items)
            {
                total += item.SubTotal();
            }

            return total;
        }

    }
}
