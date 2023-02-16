using ExercicioProHP.Entities;
namespace ExercicioProHP.Test.Entities
{
    public class ImportedProductTest
    {
        ImportedProduct sut;
        public ImportedProductTest()
        {
            sut = new ImportedProduct("Tablet", 260.00, 20.00);
        }
        [Fact]
        public void ImportedProductShouldInheritFromProduct()
        {
            Assert.IsAssignableFrom<Product>(sut);
        }
        [Fact]
        public void ImportedProductMustReceiveAPositiveCustomFee()
        {
            Action act = () => new ImportedProduct("Tablet", 260.00, -5.0);

            Assert.Throws<ArgumentOutOfRangeException>(act);
        }
        [Fact]
        public void TotalPriceMustAddCustomFeeToThePrice()
        {
            double expected = 280.0;
            double actual = sut.TotalPrice();

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void PriceTagMustAddCustomsFeeToTheInformation()
        {
            const string expected = "Tablet $ 280.00 (Customs fee: $ 20.00)";

            string actual = sut.PriceTag();

            Assert.Equal(expected, actual);
        }

    }
}
