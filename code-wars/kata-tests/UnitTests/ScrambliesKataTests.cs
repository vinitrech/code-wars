using FluentAssertions;
using katas.Scramblies;

namespace kata.tests.UnitTests;

public class ScrambliesKataTests
{
    [Theory]
    [InlineData("rkqodlw", "world", true)]
    [InlineData("cedewaraaossoqqyt", "codewars", true)]
    [InlineData("katas", "steak", false)]
    public void On_Success_Should_Validate_ScrambliesKata(string input, string wordToFind, bool expectedOutput)
    {
        ScrambliesKata.Scramble(input, wordToFind).Should().Be(expectedOutput);
    }
}
