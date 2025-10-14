using FluentAssertions;
using katas.GreedIsGood;

namespace kata.tests.UnitTests;

public class GreedIsGoodKataTests
{
    [Theory]
    [InlineData(new int[] { 2, 3, 4, 6, 2 }, 0)]
    [InlineData(new int[] { 4, 4, 4, 3, 3 }, 400)]
    [InlineData(new int[] { 2, 4, 4, 5, 4 }, 450)]
    [InlineData(new int[] { 1, 1, 2, 3, 6 }, 200)]
    [InlineData(new int[] { 5, 5, 2, 3, 6 }, 100)]
    public void On_Success_Should_Validate_GreedIsGoodKata(int[] input, int expectedOutput)
    {
        GreedIsGoodKata.Score(input).Should().Be(expectedOutput);
    }
}
