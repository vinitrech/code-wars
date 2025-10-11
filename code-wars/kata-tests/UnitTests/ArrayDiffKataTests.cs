using FluentAssertions;
using katas.ArrayDiff;

namespace kata.tests.UnitTests;

public class ArrayDiffKataTests
{
    [Theory]
    [InlineData(new int[] { 1, 2 }, new int[] { 1 }, new int[] { 2 })]
    [InlineData(new int[] { 1, 2, 2 }, new int[] { 1 }, new int[] { 2, 2 })]
    [InlineData(new int[] { 1, 2, 2 }, new int[] { 2 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 2, 2 }, new int[] { }, new int[] { 1, 2, 2 })]
    [InlineData(new int[] { }, new int[] { 1, 2 }, new int[] { })]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2 }, new int[] { 3 })]
    public void On_Success_Should_Validate_ArrayDiffKata(int[] firstArray, int[] secondArray, int[] expectedOutputArray)
    {
        ArrayDiffKata.ArrayDiff(firstArray, secondArray).Should().BeEquivalentTo(expectedOutputArray);
    }
}
