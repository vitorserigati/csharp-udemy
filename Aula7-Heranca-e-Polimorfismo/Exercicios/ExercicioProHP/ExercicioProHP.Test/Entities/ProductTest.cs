using ExercicioProHP.Entities;
namespace ExercicioProHP.Test.Entities
{
    public class ProductTest
    {
        [Theory]
        [InlineData(null, 0.5)]
        [InlineData("", 0.5)]
        [InlineData("Some Product", 0.0)]
        [InlineData("Product", -5)]
        public void ProductShouldThrowArgumentExceptionIfWrongArgumentIsPassed(string name,double price)
        {
            Action sut = () => new Product(name, price);

            Assert.Throws<ArgumentException>(sut);
        }
        [Fact]
        public void ProductShouldBeInstantiatedOnCorrectArgumentUsed()
        {
            //Arrange
            string nameExpected = "Product";
            double PriceExpected = 50.00;
            //Act
            Product sut = new Product("Product", 50.00);
            string actualName = sut.Name;
            double actualPrice = sut.Price;
            //Assert

            Assert.Equal(nameExpected, actualName);
            Assert.Equal(PriceExpected, actualPrice);
        }

        [Fact]
        public void PriceTagShouldReturnTheCorrectInformation()
        {
            //Arrange
            const string expected = "Notebook $ 1100.00";

            Product sut = new Product("Notebook", 1100.00);
            string actual = sut.PriceTag();

            Assert.Equal(expected, actual);
        }

    }
}
