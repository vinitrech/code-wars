using FluentAssertions;
using katas.DecodeTheMorseCode;

namespace kata.tests.UnitTests;

public class DecodeTheMorseCodeKataTests
{
    [Theory]
    [InlineData(".... . -.--   .--- ..- -.. .", "HEY JUDE")]
    [InlineData("...---...", "SOS")]
    public void On_Success_Should_Validate_DecodeTheMorseCodeKata(string input, string expectedOutput)
    {
        DecodeTheMorseCodeKata.Decode(input).Should().Be(expectedOutput);
    }
}
