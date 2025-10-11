using FluentAssertions;
using katas.SimplePigLatin;

namespace kata.tests.UnitTests;

public class SimplePigLatinKataTests
{
    [Theory]
    [InlineData("Pig latin is cool", "igPay atinlay siay oolcay")]
    [InlineData("This is my string", "hisTay siay ymay tringsay")]
    [InlineData("Hello world !", "elloHay orldway !")]
    public void On_Success_Should_Validate_SimplePigLatinKata(string input, string expectedOutput)
    {
        SimplePigLatinKata.PigIt(input).Should().Be(expectedOutput);
    }
}
