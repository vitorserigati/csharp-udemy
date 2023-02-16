namespace Enumeracoes
{
    using Enumeracoes.Entities;
    using Enumeracoes.Entities.Enums;
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order { Id = 1080, Moment = DateTime.Now, Status = OrderStatus.PendingPayment };
            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Shipped");
            Console.WriteLine(os);
            Console.WriteLine(txt);
            Console.WriteLine(order);
        }
    }
}
