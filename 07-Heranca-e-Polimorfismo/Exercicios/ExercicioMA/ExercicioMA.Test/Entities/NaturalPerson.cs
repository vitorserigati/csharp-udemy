namespace ExercicioMA.Test.Entities;
using ExercicioMA.Entities;


public class NaturalPersonTest
{
    NaturalPerson? sut;

    [Fact]
    public void ShouldBeSubclassOfPerson()
    {
        sut = new NaturalPerson("John Doe", 200000.0, 2000.0);

        Assert.IsAssignableFrom<Person>(sut);
    }

    [Fact]
    public void ShouldThrowArgumentNullExceptionIfPassingNullString()
    {
        Action test = () => new NaturalPerson(null, 20000.0, 200.0);

        Assert.Throws<ArgumentNullException>(test);
    }


    [Theory]
    [InlineData("", 20000.0, 200.0)]
    [InlineData(" ", 20000.0, 200.0)]
    public void ShouldThrowArgumentNullExceptionIfPassingEmptyOrWhiteSpaceString(string name, double annualIncome, double healthCare)
    {
        Action test = () => new NaturalPerson(name, annualIncome, healthCare);

        Assert.Throws<ArgumentNullException>(test);
    }

    [Fact]
    public void ShouldThrowExceptionWhenUsingNegativeValuesOnAnnualIncome()
    {
        Action test = () => new NaturalPerson("John Doe", -20000.0, 200.0);

        Assert.Throws<ArgumentOutOfRangeException>(test);
    }



    [Fact]
    public void ShouldThrowArgumentOutOfRangeExceptionWhenUsingNegativeValuesOnHealthCare()
    {
        Action test = () => new NaturalPerson("John Doe", 20000.0, -200.0);

        Assert.Throws<ArgumentOutOfRangeException>(test);
    }

    [Theory]
    [InlineData(11500.00, "John Doe", 50000.00, 2000.00)]
    [InlineData(2850.00, "John Doe", 19000.00, 0.0)]
    [InlineData(5000.00, "John Doe", 20000.00, 0.0)]
    public void ShouldCalculateTheRightTaxForEachInput(double expected, string name, double annualIncome, double healthCare)
    {
       sut = new NaturalPerson(name, annualIncome, healthCare);
        double actual = sut.CalculateTax();

        Assert.Equal(expected, actual);
    }

}
