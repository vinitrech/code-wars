using FluentAssertions;
using katas.RomanNumeralsHelper;

namespace kata.tests.UnitTests;

public class RomanNumeralsHelperKataTests
{
    [Theory]
    [InlineData(1, "I")]
    [InlineData(2, "II")]
    [InlineData(4, "IV")]
    [InlineData(2464, "MMCDLXIV")]
    public void On_Success_Should_Validate_RomanNumeralsHelperKata_ToRoman(int input, string expectedOutput)
    {
        var output = RomanNumeralsHelperKata.ToRoman(input);

        output.Should().Be(expectedOutput);
    }

    [Theory]
    [InlineData("I", 1)]
    [InlineData("II", 2)]
    [InlineData("IV", 4)]
    [InlineData("MMCDLXIV", 2464)]
    public void On_Success_Should_Validate_RomanNumeralsHelperKata_FromRoman(string input, int expectedOutput)
    {
        var output = RomanNumeralsHelperKata.FromRoman(input);

        output.Should().Be(expectedOutput);
    }
}
