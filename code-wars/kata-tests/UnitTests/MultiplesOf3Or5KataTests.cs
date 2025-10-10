using FluentAssertions;
using katas.MultiplesOf3Or5;

namespace kata.tests.UnitTests;

public class MultiplesOf3Or5KataTests
{
    [Theory]
    [InlineData(10, 23)]
    [InlineData(20, 78)]
    [InlineData(200, 9168)]
    [InlineData(0, 0)]
    public void On_Success_Should_Validate_MultiplesOf3Or5Kata(int input, int expectedOutput)
    {
        MultiplesOf3Or5Kata.Solution(input).Should().Be(expectedOutput);
    }
}
