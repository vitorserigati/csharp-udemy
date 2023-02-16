namespace ExercicioP.Test.Entities;
using ExercicioP.Entities;

public class ProductTest
{
    [Theory]
    [InlineData("", 5.0)]
    [InlineData(" ", 5.0)]
    public void ShouldThrowArgumentExceptionOnParameterInput(string name, double price)
    {

        try
        {
            Product product = new Product(name, price);
        }
        catch (Exception e)
        {
            Assert.IsType<ArgumentException>(e);

        }
    }
}

