using FluentAssertions;
using katas.CountingChangeCombinations;

namespace kata.tests.UnitTests;

public class CountingChangeCombinationsKataTests
{
    [Theory]
    [InlineData(4, new[] {1, 2}, 3)]
    [InlineData(10, new[] {5, 2, 3}, 4)]
    [InlineData(11, new[] {5, 7}, 0)]
    public void On_Success_Should_Validate_ASimplisticTCPFiniteStateMachineKata(int money, int[] coins, int expectedOutput)
    {
        CountingChangeCombinationsKata.CountCombinations(money, coins).Should().Be(expectedOutput);
    }
}
