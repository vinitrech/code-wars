using FluentAssertions;
using katas.CountOnesInASegment;

namespace kata.tests.UnitTests;

public class CountOnesInASegmentKataTests
{
    [Theory]
    [InlineData(5, 7, 7)]
    [InlineData(12, 29, 51)]
    public void On_Success_Should_Validate_CountOnesInASegmentKata(long left, long right, long expectedOutput)
    {
        CountOnesInASegmentKata.CountOnes(left, right).Should().Be(expectedOutput);
    }
}