using FluentAssertions;
using katas.DecodeTheMorseCodeAdvanced;

namespace kata.tests.UnitTests;

public class DecodeTheMorseCodeAdvancedKataTests
{
    [Fact]
    public void On_Success_Should_Validate_DecodeTheMorseCodeAdvancedKata_DecodeBits()
    {
        DecodeTheMorseCodeAdvancedKata.DecodeBits("1100110011001100000011000000111111001100111111001111110000000000000011001111110011111100111111000000110011001111110000001111110011001100000011")
            .Should().Be(".... . -.--   .--- ..- -.. .");
    }

    [Fact]
    public void On_Success_Should_Validate_DecodeTheMorseCodeAdvancedKata_DecodeMorse()
    {
        DecodeTheMorseCodeAdvancedKata.DecodeMorse(DecodeTheMorseCodeAdvancedKata.DecodeBits("1100110011001100000011000000111111001100111111001111110000000000000011001111110011111100111111000000110011001111110000001111110011001100000011"))
            .Should().Be("HEY JUDE");
    }
}
