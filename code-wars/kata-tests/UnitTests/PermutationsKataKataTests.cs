using FluentAssertions;
using katas.Permutations;

namespace kata.tests.UnitTests;

public class PermutationsKataKataTests
{
    [Theory]
    [InlineData("a", new string[] { "a" })]
    [InlineData("ab", new string[] { "ab", "ba" })]
    [InlineData("aabb", new string[] { "aabb", "abab", "abba", "baab", "baba", "bbaa" })]
    public void On_Success_Should_Validate_PermutationsKata(string inputText, string[] expectedOutput)
    {
        PermutationsKata.SinglePermutations(inputText).Should().BeEquivalentTo(expectedOutput);
    }
}
