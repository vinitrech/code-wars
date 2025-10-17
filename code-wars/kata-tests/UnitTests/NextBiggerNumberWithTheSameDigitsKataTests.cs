using FluentAssertions;
using katas.NextBiggerNumberWithTheSameDigits;

namespace kata.tests.UnitTests;

public class NextBiggerNumberWithTheSameDigitsKataTests
{
    [Theory]
    [InlineData(12, 21)]
    [InlineData(513, 531)]
    [InlineData(2017, 2071)]
    [InlineData(414, 441)]
    [InlineData(144, 414)]
    [InlineData(531, -1)]
    [InlineData(111, -1)]
    [InlineData(9, -1)]
    [InlineData(1234567890, 1234567908)]
    [InlineData(1318113062, 1318113206)]
    public void On_Success_Should_Validate_NextBiggerNumberWithTheSameDigitsKata(long input, long expectedOutput)
    {
        NextBiggerNumberWithTheSameDigitsKata.NextBiggerNumber(input).Should().Be(expectedOutput);
    }
}
