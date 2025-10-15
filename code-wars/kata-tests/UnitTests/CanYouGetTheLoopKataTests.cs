using FluentAssertions;
using katas.CanYouGetTheLoop;

namespace kata.tests.UnitTests;

public class CanYouGetTheLoopKataTests
{
    [Theory]
    [InlineData(3, 30)]
    [InlineData(3904, 1087)]
    [InlineData(4, 3)]
    public void On_Success_Should_Validate_CanYouGetTheLoopKata(int tailSize, int loopSize)
    {
        // arrange
        var startNode = Node.CreateChain(tailSize, loopSize);

        // act
        var result = CanYouGetTheLoopKata.GetLoopSize(startNode);

        // assert
        result.Should().Be(loopSize);
    }
}