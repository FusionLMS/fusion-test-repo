namespace ConsoleApp1.Tests;

public class SimpleCalculatorTests
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(2, 3, 5)]
    [InlineData(3, 4, 7)]
    [InlineData(4, 5, 9)]
    public void Sum_ParamsValid_Success(int a, int b, int expected)
    {
        var actual = SimpleCalculator.Sum(a, b);
        Assert.Equal(expected, actual);
    }
}