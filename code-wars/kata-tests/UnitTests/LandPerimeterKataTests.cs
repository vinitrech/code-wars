using FluentAssertions;
using katas.LandPerimeter;

namespace kata.tests.UnitTests;

public class LandPerimeterKataTests
{
    [Theory]
    [InlineData("", "Total land perimeter: 0")]
    [InlineData("O", "Total land perimeter: 0")]
    [InlineData("X", "Total land perimeter: 4")]
    [InlineData("OXOOOX OXOXOO XXOOOX OXXXOO OOXOOX OXOOOO OOXOOX OOXOOO OXOOOO OXOOXX", "Total land perimeter: 60")]
    [InlineData("OXOOO OOXXX OXXOO XOOOO XOOOO XXXOO XOXOO OOOXO OXOOX XOOOO OOOXO", "Total land perimeter: 52")]
    [InlineData("XXXXXOOO OOXOOOOO OOOOOOXO XXXOOOXO OXOXXOOX", "Total land perimeter: 40")]
    [InlineData("XOOOXOO OXOOOOO XOXOXOO OXOXXOO OOOOOXX OOOXOXX XXXXOXO", "Total land perimeter: 54")]
    [InlineData("OOOOXO XOXOOX XXOXOX XOXOOO OOOOOO OOOXOO OOXXOO", "Total land perimeter: 40")]
    public void On_Success_Should_Validate_LandPerimeterKata(string input, string expectedOutput)
    {
        LandPerimeterKata.Calculate(input.Split(" ")).Should().Be(expectedOutput);
    }
}
