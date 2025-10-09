using FluentAssertions;
using katas.SumOfTwoLowestPositiveIntegers;

namespace kata.tests.UnitTests;

public class SumOfTwoLowestPositiveIntegersKataTests
{
    [Theory]
    [InlineData(new int[] { 19, 5, 42, 2, 77 }, 7)]
    [InlineData(new int[] { 10, 343445353, 3453445, 2147483647 }, 3453455)]
    [InlineData(new int[] { 5, 8, 12, 19, 22 }, 13)]
    public void On_Success_Should_Validate_SumOfTwoLowestPositiveIntegersKata(int[] input, int expectedOutput)
    {
        SumOfTwoLowestPositiveIntegersKata.SumTwoSmallestNumbers(input).Should().Be(expectedOutput);
    }
}
