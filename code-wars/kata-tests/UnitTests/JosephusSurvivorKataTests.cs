using FluentAssertions;
using katas.JosephusSurvivor;

namespace kata.tests.UnitTests;

public class JosephusSurvivorKataTests
{
    [Theory]
    [InlineData(7, 3, 4)]
    [InlineData(11, 19, 10)]
    [InlineData(40, 3, 28)]
    [InlineData(14, 2, 13)]
    [InlineData(100, 1, 100)]
    [InlineData(1, 300, 1)]
    [InlineData(2, 300, 1)]
    [InlineData(5, 300, 1)]
    [InlineData(7, 300, 7)]
    [InlineData(300, 300, 265)]
    public void On_Success_Should_Validate_JosephusSurvivorKata(int group, int step, int expectedOutput)
    {
        var output = JosephusSurvivorKata.JosSurvivor(group, step);

        output.Should().Be(expectedOutput);
    }
}
