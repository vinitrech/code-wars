using FluentAssertions;
using katas.MeanSquareError;

namespace kata.tests.UnitTests;

public class MeanSquareErrorKataTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, 9d)]
    [InlineData(new int[] { 10, 20, 10, 2 }, new int[] { 10, 25, 5, -2 }, 16.5d)]
    [InlineData(new int[] { 0, -1 }, new int[] { -1, 0 }, 1d)]
    public void On_Success_Should_Validate_MeanSquareErrorKata(int[] firstArray, int[] secondArray, double expectedOutput)
    {
        MeanSquareErrorKata.Solution(firstArray, secondArray).Should().Be(expectedOutput);
    }
}
