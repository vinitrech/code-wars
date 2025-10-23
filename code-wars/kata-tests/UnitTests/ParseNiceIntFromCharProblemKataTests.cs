using FluentAssertions;
using katas.ParseNiceIntFromCharProblem;

namespace kata.tests.UnitTests;

public class ParseNiceIntFromCharProblemKataTests
{
    [Theory]
    [InlineData("4 years old", 4)]
    [InlineData("5 years old", 5)]
    [InlineData("6 years old", 6)]
    public void On_Success_Should_Validate_ParseNiceIntFromCharProblemKata(string input, int expectedOutput)
    {
        ParseNiceIntFromCharProblemKata.GetAge(input).Should().Be(expectedOutput);
    }
}
