using ExercicioProHP.Entities;
namespace ExercicioProHP.Test.Entities
{
    public class UsedProductTest
    {
        UsedProduct sut;
        public UsedProductTest()
        {
            sut = new UsedProduct("Product", 50.00, "02/02/2023");
        }

        [Theory]
        [InlineData("Product", 50.00, null)]
        [InlineData("Product", 50.00, "")]
        public void ClassShouldThrowExceptionWhenInstatiatedWithoutDate(string name, double price, string date)
        {
            Action a = () => new UsedProduct(name, price, date);

            Assert.Throws<ArgumentException>(a);
        }

        [Fact]
        public void ClassShouldBeInheritedFromProduct()
        {
            Assert.IsAssignableFrom<Product>(sut);
        }

        [Fact]
        public void PriceTagShouldShowInfoUsedAndDateOFManufacture()
        {
            const string expected = "Product (used) $ 50.00 (Manufacture date: 02/02/2023)";
            string actual = sut.PriceTag();

            Assert.Equal(expected, actual);
        }
    }
}
