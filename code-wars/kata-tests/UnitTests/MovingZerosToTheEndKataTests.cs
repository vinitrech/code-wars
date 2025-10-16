using FluentAssertions;
using katas.MovingZerosToTheEnd;

namespace kata.tests.UnitTests;

public class MovingZerosToTheEndKataTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }, new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 })]
    public void On_Success_Should_Validate_MovingZerosToTheEndKata(int[] sourceArray, int[] expectedArray)
    {
        var outputArray = MovingZerosToTheEndKata.MoveZeroes(sourceArray);

        outputArray.Should().BeEquivalentTo(expectedArray);
    }
}
