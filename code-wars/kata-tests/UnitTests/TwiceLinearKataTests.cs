using FluentAssertions;
using katas.TwiceLinear;

namespace kata.tests.UnitTests;

public class TwiceLinearKataTests
{
    [Theory]
    [InlineData(10, 22)]
    [InlineData(20, 57)]
    [InlineData(30, 91)]
    [InlineData(50, 175)]
    [InlineData(100, 447)]
    [InlineData(500, 3355)]
    [InlineData(1000, 8488)]
    [InlineData(2000, 19773)]
    [InlineData(6000, 80914)]
    [InlineData(60000, 1511311)]
    public void On_Success_Should_Validate_TwiceLinearKata(int inputNumber, int expectedOutput)
    {
        TwiceLinearKata.DblLinear(inputNumber).Should().Be(expectedOutput);
    }
}
