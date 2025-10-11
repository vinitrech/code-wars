using FluentAssertions;
using katas.DetectPangram;

namespace kata.tests.UnitTests;

public class DetectPangramKataTests
{
    [Theory]
    [InlineData("The quick brown fox jumps over the lazy dog.", true)]
    public void On_Success_Should_Validate_DetectPangramKata(string input, bool expectedOutput)
    {
        DetectPangramKata.IsPangram(input).Should().Be(expectedOutput);
    }
}
