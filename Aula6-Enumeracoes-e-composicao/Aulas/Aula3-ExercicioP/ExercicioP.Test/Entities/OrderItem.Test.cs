using ExercicioP.Entities;
namespace ExercicioP.Test.Entities
{
    public class OrderItemTest
    {
        [Theory]
        [InlineData(52.5, 5, 10.5)]
        [InlineData(15.0, 10, 1.5)]
        public void subTotalShouldCalculateTheRightValue(double result, int quantity, double price)
        {
            OrderItem order = new OrderItem(quantity, price, "Product");
            double actual = order.subTotal();

            Assert.Equal(result, actual);

        }
    }
}
