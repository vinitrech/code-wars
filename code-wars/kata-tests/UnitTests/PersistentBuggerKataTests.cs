using FluentAssertions;
using katas.PersistentBugger;

namespace kata.tests.UnitTests;

public class PersistentBuggerKataTests
{
    [Theory]
    [InlineData(39, 3)]
    [InlineData(4, 0)]
    [InlineData(25, 2)]
    [InlineData(999, 4)]
    public void On_Success_Should_Validate_PersistentBuggerKata(long input, int expectedOutput)
    {
        PersistentBuggerKata.Persistence(input).Should().Be(expectedOutput);
    }
}
