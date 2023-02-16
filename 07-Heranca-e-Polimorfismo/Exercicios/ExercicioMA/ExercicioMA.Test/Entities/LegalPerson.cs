namespace ExercicioMA.Test.Entities;
using ExercicioMA.Entities;
public class LegalPersonTest
{
    LegalPerson? sut;

    [Fact]
    public void ShouldBeSubclassOfPerson()
    {
        sut = new LegalPerson("Unknown Business", 400000.0, 25);

        Assert.IsAssignableFrom<Person>(sut);
    }

    [Fact]
    public void ShouldthrowArgumentNullExceptionIfPassingNullString()
    {
        Action test = () => new LegalPerson(null, 400000.0, 25);

        Assert.Throws<ArgumentNullException>(test);
    }

    [Theory]
    [InlineData("", 400000.0, 25)]
    [InlineData(" ", 400000.0, 25)]
    public void ShouldThrowArgumentNullExceptionIfPassingEmptyOrWhiteString(string name, double annualIncome, int employeeNumber)
    {
        Action test = () => new LegalPerson(name, annualIncome, employeeNumber);

        Assert.Throws<ArgumentNullException>(test);
    }

    [Fact]
    public void ShouldThrowExceptionWhenUsingNegativeValuesOnAnnualIncome()
    {
        Action test = () => new LegalPerson("Unknown Business", -1.0, 25);

        Assert.Throws<ArgumentOutOfRangeException>(test);
    }

    [Fact]
    public void ShouldThrowArgumentOutOfRangeExceptionWhenUsingNegativeValuesOnEmployeeNumber()
    {
        Action test = () => new LegalPerson("Unknown Business", 400000.0, -1);

        Assert.Throws<ArgumentOutOfRangeException>(test);
    }

    [Theory]
    [InlineData(56000.00, "Unknown Business", 400000.0, 25)]
    [InlineData(48000.00, "Unknown Business", 300000.0, 5)]
    [InlineData(14000.00, "Unknown Business", 100000.0, 25)]
    public void ShouldCalculateTheRightTaxForEachInput(double expected, string name, double annualIncome, int employeeNumber)
    {
        sut = new LegalPerson(name, annualIncome, employeeNumber);
        double actual = sut.CalculateTax();

        Assert.Equal(expected, actual);
    }

}


