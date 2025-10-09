using FluentAssertions;
using katas.ExesAndOhs;

namespace kata.tests.UnitTests;

public class ExesAndOhsKataTests
{
    [Theory]
    [InlineData("xo", true)]
    [InlineData("xxOo", true)]
    [InlineData("xxxm", false)]
    [InlineData("Oo", false)]
    [InlineData("ooom", false)]
    public void On_Success_Should_Validate_StopSpinningMyWordsKata(string input, bool expectedOutput)
    {
        ExesAndOhsKata.XO(input).Should().Be(expectedOutput);
    }
}
