using FluentAssertions;
using kata_solutions.StopSpinningMyWords;

namespace stop_gninnips_my_sdrow_tests;

public class StopSpinningMyWordsKataTests
{
    [Theory]
    [InlineData("Hey fellow warriors", "Hey wollef sroirraw")]
    [InlineData("This is a test", "This is a test")]
    [InlineData("This is another test", "This is rehtona test")]
    public void On_Success_Should_Validate_StopSpinningMyWordsKata(string input, string expectedOutput)
    {
        StopSpinningMyWordsKata.SpinWords(input).Should().Be(expectedOutput);
    }
}
