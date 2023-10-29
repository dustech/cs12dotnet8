using CalculatorLib;

namespace MyCalculatorLibUnitTests;

public class MyPiccoliTests
{
    [Fact]
    public void ShouldAddTwoAndThreeResultFive()
    {
        // Arrange
        double a = 2;
        double b = 3;
        double expected = 5;
        Calculator calc = new();

        // Act

        double actual = calc.Add(a, b);

        // Assert

        Assert.Equal(expected, actual);


    }

    [Fact]
    public void ShouldAddTwoAndThreeDifferSix()
    {
        // Arrange
        double a = 2;
        double b = 3;
        double differ = 6;
        Calculator calc = new();

        // Act

        double actual = calc.Add(a, b);

        // Assert

        Assert.NotEqual(differ, actual);


    }

    [Fact]
    public void ShouldDivideByZeroThrowArgumentOutOfRangeException()
    {
        // Arrange
        double di = 4;
        double divisor = 0;
        Calculator calc = new();

        // Act
        // Assert
        Assert.Throws<ArgumentOutOfRangeException>
        (() => calc.Divide(dividendo: di, divisore: divisor));


    }
}